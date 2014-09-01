using UnityEngine;
using System.Collections;

public class PlayerWeapon : BaseWeapon
{
    #region Fields



    #endregion

    #region Methods

    /// <summary>
    /// Update game logic.
    /// </summary>
    void Update()
    {
        // 
        Vector2 shotDirection = InputControl.GetShotDirection();
    }

    #endregion
}
