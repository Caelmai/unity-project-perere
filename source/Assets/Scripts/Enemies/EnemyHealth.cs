using UnityEngine;
using System.Collections;

public class EnemyHealth : BaseHealth
{
    #region Fields

    #endregion

    #region Methods

    /// <summary>
    /// Called when script start.
    /// </summary>
    void Start()
    {
        currentHeath = GameSettings.CapeloboInitialHealth;
    }

    /// <summary>
    /// A method to watch enemy death.
    /// </summary>
    protected override void OnDeath()
    {
        print(string.Format("The {0} is dead!", gameObject.name));
    }

    #endregion
}
