using UnityEngine;
using System.Collections;

public abstract class EnemyBehavior : MonoBehaviour
{
    #region Fields

    /// <summary>
    /// Enemy movement.
    /// </summary>
    protected Vector2 movement;

    /// <summary>
    /// Current walk speed.
    /// </summary>
    protected float currentWalkSpeed;

    /// <summary>
    /// Current enemy status.
    /// </summary>
    protected EnemyStatus currentStatus;

    #endregion
}
