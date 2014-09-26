using UnityEngine;
using System.Collections;

public class PlayerWeapon : BaseWeapon
{
    #region Fields

    #endregion

    #region Methods

    /// <summary>
    /// Update game logic.
    /// </summary>
    void Update()
    {
        // If shot button is pressed.
        if (InputControl.IsShotEnabled)
        {
            // Mouse position.
            Vector3 mousePosition = InputControl.GetMousePosition(transform.position, mainCamera);

            // Figure out angle.
            Quaternion angle = Quaternion.FromToRotation(Vector3.up, mousePosition - transform.position);

            // Get shot from pool.
            GameObject shot = GetObjectFromPool(transform.position, angle);

            // Add force on shot.
            shot.transform.TryAddRigidbodyForce(shot.transform.up * GameSettings.PlayerShotSpeed);

            // Kickback shot.
            transform.parent.TryAddRigidbodyForce(-shot.transform.up * GameSettings.PlayerKickbackShot);

            // Start camera shake.
            CameraShake.Instance.Shake();
        }
    }

    #endregion
}
