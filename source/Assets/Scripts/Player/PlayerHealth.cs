using UnityEngine;
using System.Collections;

public class PlayerHealth : BaseHealth
{
    #region Fields

    /// <summary>
    /// Default shot speed method name.
    /// </summary>
    protected const string RecoverMethod = "Recover";

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
    /// Draw status.
    /// </summary>
    void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 120, 40), "HEALTH: " + currentHeath);
    }

    /// <summary>
    /// Detect other collider against this one.
    /// </summary>
    /// <param name="collision">The collision.</param>
    void OnCollisionStay2D(Collision2D collision)
    {
        if (!isRecovering && collision.gameObject.tag == GameSettings.EnemyTag)
        {
            isRecovering = true;

            Invoke(RecoverMethod, GameSettings.PlayerTimeToRecover);

            Damage(GameSettings.PlayerCollisionAgainstEnemies);
        }
    }

    /// <summary>
    /// To increase health when use a guaraná item.
    /// </summary>
    public void IncreaseHealth()
    {
        currentHeath += GameSettings.GuaranaHealingEffect;
    }

    /// <summary>
    /// A method to watch player death.
    /// </summary>
    protected override void OnDeath()
    {
        print("The player is dead!");
    }

    /// <summary>
    /// Recover control.
    /// </summary>
    protected void Recover()
    {
        renderer.enabled = true;

        isRecovering = false;
    }

    #endregion
}
