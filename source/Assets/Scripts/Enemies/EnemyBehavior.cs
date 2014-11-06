using UnityEngine;
using System.Collections;

public abstract class EnemyBehavior : BaseScript
{
    #region Fields

    /// <summary>
    /// Player layer mask.
    /// </summary>
    protected LayerMask playerLayerMask;
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
    /// <summary>
    /// Start position.
    /// </summary>
    protected Vector2 startPosition;

    #endregion

    #region Methods

    /// <summary>
    /// Called when script start.
    /// </summary>
    void Start()
    {
        startPosition = transform.position;

        playerLayerMask = LayerMask.NameToLayer(GameSettings.PlayerLayerMask);

        Initilize();
    }

    /// <summary>
    /// Detect collision enter.
    /// </summary>
    void OnCollisionEnter2D(Collision2D collision)
    {
        OnCollisionHit(collision, EnemyStatus.Attack);
    }

    /// <summary>
    /// Detect collision stay.
    /// </summary>
    void OnCollisionStay2D(Collision2D collision)
    {
        OnCollisionHit(collision, EnemyStatus.Attack);
    }

    /// <summary>
    /// Detect collision exit.
    /// </summary>
    void OnCollisionExit2D(Collision2D collision)
    {
        OnCollisionHit(collision, EnemyStatus.Idle);
    }

    /// <summary>
    /// Method to initialize variables.
    /// </summary>
    protected abstract void Initilize();

    /// <summary>
    /// Detect collision hit enter.
    /// </summary>
    protected abstract void OnCollisionHit(Collision2D collision, EnemyStatus nextStatus);

    /// <summary>
    /// Method to evaluate enemy status.
    /// </summary>
    protected abstract void EvaluateEnemyStatus();

    /// <summary>
    /// Method to implement enemy status behavior.
    /// </summary>
    protected abstract void UpdateCurrentEnemyStatus();

    /// <summary>
    /// Update enemy when status is chase.
    /// </summary>
    protected void UpdateChaseStatus(Vector2 target)
    {
        transform.position = Vector2.MoveTowards(transform.position, target, currentWalkSpeed * Time.deltaTime);
    }

    /// <summary>
    /// Method to wait before change status.
    /// </summary>
    protected IEnumerator WaitToChangeStatus(float waitTime, EnemyStatus nextStatus)
    {
        yield return new WaitForSeconds(waitTime);

        currentStatus = nextStatus;
    }

    #endregion
}
