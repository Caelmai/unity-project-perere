using UnityEngine;
using System.Collections;

public class PlayerWeapon : BaseWeapon
{
    #region Fields

    /// <summary>
    /// If kickback shot is enabled.
    /// </summary>
    [SerializeField]
    private bool kickbackShotEnabled;

    /// <summary>
    /// If camera shake is enabled.
    /// </summary>
    [SerializeField]
    private bool cameraShakeEnabled;

    #endregion

    #region Properties

    /// <summary>
    /// Se if cassava effect is active.
    /// </summary>
    private bool ActiveCassavaEffect
    {
        set
        {
            kickbackShotEnabled = cameraShakeEnabled = value;
        }
    }

    #endregion

    #region Methods

    /// <summary>
    /// When script starts.
    /// </summary>
    void Start()
    {
        SetDefaultShotSpeed();
    }

    /// <summary>
    /// Update game logic.
    /// </summary>
    void Update()
    {
        // If shot button is pressed.
        if (InputControl.IsShotEnabled)
        {
            // Mouse position.
            Vector3 mousePosition = InputControl.GetMousePosition(transform.position, GameManager.Instance.MainCamera);

            // Figure out angle.
            Quaternion angle = Quaternion.FromToRotation(Vector3.up, mousePosition - transform.position);

            // Get shot from pool.
            GameObject shot = GetObjectFromPool(transform.position, angle);

            // Add force on shot.
            shot.transform.TryAddRigidbodyForce(shot.transform.up * currentShotSpeed);

            // Kickback shot.
            if (kickbackShotEnabled)
            {
                transform.parent.TryAddRigidbodyForce(-shot.transform.up * GameSettings.PlayerKickbackShot);
            }

            // Start camera shake.
            if (cameraShakeEnabled)
            {
                CameraShake.Instance.Shake();
            }
        }
    }

    /// <summary>
    /// To increase weapon when use a cassava item.
    /// </summary>
    public void IncreaseShotSpeed()
    {
        ActiveCassavaEffect = true;

        currentShotSpeed = GameSettings.PlayerShotCassavaEffectSpeed;

        Invoke(SetDefaultShotSpeedMethod, GameSettings.CassavaEffectTime);
    }

    /// <summary>
    /// To set default shot speed.
    /// </summary>
    protected override void SetDefaultShotSpeed()
    {
        ActiveCassavaEffect = false;

        currentShotSpeed = GameSettings.PlayerShotSpeed;
    }

    #endregion
}
