using UnityEngine;
using System.Collections;

public abstract class BaseShot : BaseScript
{
    #region Fields

    /// <summary>
    /// The shot damage.
    /// </summary>
    protected int currentDamage;

    #endregion

    #region Properties

    /// <summary>
    /// Get the shot damage.
    /// </summary>
    public int Damage
    {
        get { return currentDamage; }
    }

    /// <summary>
    /// Set if game object is active.
    /// </summary>
    public bool Active
    {
        get { return gameObject.activeInHierarchy; }
        set { gameObject.SetActive(value); }
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
            Active = false;
        }
    }

    #endregion
}
