using UnityEngine;
using System.Collections;

public class BaseShot : BaseScript
{
    #region Fields

    /// <summary>
    /// The shot damage.
    /// </summary>
    protected int currentShotDamage;

    #endregion

    #region Properties

    /// <summary>
    /// Get the shot damage.
    /// </summary>
    public int ShotDamage
    {
        get { return currentShotDamage; }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Update game logic.
    /// </summary>
    void Update()
    {
        // If shot is not visible (outside of camera view).
        if (!renderer.isVisible)
        {
            // Return to pool.  
            gameObject.SetActive(false);
        }
    }

    #endregion
}
