using UnityEngine;
using System.Collections;

public class CapeloboBehavior : EnemyBehavior
{
    #region Fields

    /// <summary>
    /// 
    /// </summary>
    private Sprite originalSprite;

    /// <summary>
    /// 
    /// </summary>
    private Sprite disguiseSprite;

    #endregion

    #region Methods

    /// <summary>
    /// Called when script start.
    /// </summary>
    void Start()
    {
        currentStatus = EnemyStatus.Idle;
    }

    #endregion
}
