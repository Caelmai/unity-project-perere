using UnityEngine;
using System.Collections;

public class PlayerShot : BaseShot
{
    #region Fields

    private bool isRising;

    #endregion

    #region Methods

    /// <summary>
    /// Called when script start.
    /// </summary>
    void Start()
    {
        currentDamage = GameSettings.PlayerInitialShotDamage;
    }

    /// <summary>
    /// Called when
    /// </summary>
    public void OnShotBehaviorAnimationIsEnded()
    {
        // Return to pool.  
        Active = false;
    }

    #endregion
}
