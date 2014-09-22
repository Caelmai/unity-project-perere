using UnityEngine;
using System.Collections;

public class PlayerShot : BaseShot
{
    #region Fields
 
    #endregion

    #region Methods

    void Start()
    {
        currentShotDamage = GameSettings.PlayerInitialShotDamage;
    }

    #endregion
}
