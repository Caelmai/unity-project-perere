using UnityEngine;
using System.Collections;

public class PlayerShot : BaseScript
{
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
