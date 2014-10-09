using UnityEngine;
using System.Collections;

public class PlayerShot : BaseShot
{
    #region Fields

    #endregion

    #region Methods

    /// <summary>
    /// Called when script start.
    /// </summary>
    void Start()
    {
        currentDamage = GameSettings.PlayerInitialShotDamage;
    }

    #endregion
}
