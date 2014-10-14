using UnityEngine;
using System.Collections;

public class EnemyHealth : BaseHealth
{
    #region Fields

    /// <summary>
    /// Original color.
    /// </summary>
    protected Color originalColor;

    /// <summary>
    /// Color when hit.
    /// </summary>
    protected Color hitColor;

    #endregion

    #region Methods

    /// <summary>
    /// Initializ variables.
    /// </summary>
    protected override void Starting()
    {
        currentHeath = GameSettings.CapeloboInitialHealth;

        invokeOriginalRenderer = GameSettings.EnemyInvokeOriginalRenderer;

        originalColor = Color.white;
        hitColor = Color.red;
    }

    /// <summary>
    /// Update game logic.
    /// </summary>
    protected override void Updating()
    {
        Color color = spriteRenderer.color;

        if (color == originalColor)
        {
            color.g = hitColor.g;
            color.b = hitColor.b;
        }
        else if (color == hitColor)
        {
            color.g = originalColor.g;
            color.b = originalColor.b;
        }

        spriteRenderer.color = color;
    }

    /// <summary>
    /// A method called when enemy dies.
    /// </summary>
    protected override void OnDeath()
    {
        print(string.Format("The {0} is dead!", gameObject.name));
    }

    /// <summary>
    /// A method to return renderer to orginal setting.
    /// </summary>
    protected override void SetOriginalRenderer()
    {
        base.SetOriginalRenderer();

        spriteRenderer.color = originalColor;
    }
    #endregion
}
