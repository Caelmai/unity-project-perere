using UnityEngine;
using System.Collections;

public class PlayerHealth : BaseHealth
{
    #region Fields

    /// <summary>
    /// Player is recovering.
    /// </summary>
    private bool isRecovering;

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
    /// Detect other collider against this one.
    /// </summary>
    /// <param name="collision">The collision.</param>
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == GameSettings.EnemyTag)
        {
            Damage(GameSettings.PlayerCollisionAgainstEnemies);
        }
    }

    #endregion
}
