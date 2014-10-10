using UnityEngine;
using System.Collections;

public abstract class BaseWeapon : GenericPooling
{
    #region Fields

    /// <summary>
    /// Default shot speed method name.
    /// </summary>
    protected const string SetDefaultShotSpeedMethod = "SetDefaultShotSpeed";

    /// <summary>
    /// Current shot speed.
    /// </summary>
    protected float currentShotSpeed;

    #endregion

    #region Methods

    /// <summary>
    /// To set default shot speed.
    /// </summary>
    protected abstract void SetDefaultShotSpeed();

    #endregion
}
