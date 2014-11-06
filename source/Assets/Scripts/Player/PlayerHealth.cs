using UnityEngine;
using System.Collections;

public class PlayerHealth : BaseHealth
{
    #region Fields

    #endregion

    #region Methods

    /// <summary>
    /// Detect other collider against this one.
    /// </summary>
    /// <param name="collision">The collision.</param>
    void OnCollisionStay2D(Collision2D collision)
    {
        if (!wasHit && collision.gameObject.tag == GameSettings.EnemyTag)
        {
            Damage(GameSettings.PlayerCollisionAgainstEnemies);
        }
    }

    /// <summary>
    /// Draw status.
    /// </summary>
    void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 120, 40), "HEALTH: " + currentHeath);
    }

    /// <summary>
    /// Initialize variables.
    /// </summary>
    protected override void Starting()
    {
        currentHeath = GameSettings.PlayerInitialHealth;

        invokeOriginalRenderer = GameSettings.PlayerInvokeOriginalRenderer;
    }

    /// <summary>
    /// Update game logic.
    /// </summary>
    protected override void Updating()
    {
        renderer.enabled = !renderer.enabled;
    }

    /// <summary>
    /// A method called when player dies.
    /// </summary>
    protected override void OnDeath()
    {
        print("The player is dead!");
    }

    /// <summary>
    /// To increase health when use a guaraná item.
    /// </summary>
    public void IncreaseHealth()
    {
        currentHeath += GameSettings.GuaranaHealingEffect;
    }

    /// <summary>
    /// A method to return renderer to orginal setting.
    /// </summary>
    protected override void ResetComponentsSettings()
    {
        base.ResetComponentsSettings();

        renderer.enabled = true;
    }

    #endregion
}
