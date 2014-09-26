using UnityEngine;
using System.Collections;

public class PlayerHealth : BaseHealth
{
    #region Fields

    /// <summary>
    /// Player is recovering.
    /// </summary>
    private bool isRecovering;

    /// <summary>
    /// Recovering changer timer.
    /// </summary>
    private int recoverChangerTimer = 0;

    #endregion

    #region Methods

    /// <summary>
    /// Called when script start.
    /// </summary>
    void Start()
    {
        currentHeath = GameSettings.PlayerInitialHealth;
    }

    /// <summary>
    /// Update game logic.
    /// </summary>
    void Update()
    {
        if (isRecovering)
        {
            recoverChangerTimer += 1;

            if (recoverChangerTimer > GameSettings.PlayerRecoverChangerTimer)
            {
                recoverChangerTimer = 0;

                renderer.enabled = !renderer.enabled;
            }
        }
    }

    /// <summary>
    /// Detect other collider against this one.
    /// </summary>
    /// <param name="collision">The collision.</param>
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isRecovering && collision.gameObject.tag == GameSettings.EnemyTag)
        {
            isRecovering = true;

            Invoke("Recover", GameSettings.PlayerTimeToRecover);

            Damage(GameSettings.PlayerCollisionAgainstEnemies);
        }
    }

    /// <summary>
    /// Recover.
    /// </summary>
    private void Recover()
    {
        renderer.enabled = true;

        isRecovering = false;

        CancelInvoke("Recover");
    }

    #endregion
}
