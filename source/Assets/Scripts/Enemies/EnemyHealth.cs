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

    #endregion
}
