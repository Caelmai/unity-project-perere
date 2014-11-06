using UnityEngine;
using System.Collections;

/// <summary>
/// GUARD: Waiting near some important door/passage.
/// RETURN TO GUARD: When is backing to guard position.
/// CHASE: Was triggered to chase player.
/// IDLE: When loose the player and is wating to change to return to guard.
/// ATTACK: When reach player and will attack him.
/// </summary>
public class ArrancaLinguasBehavior : EnemyBehavior
{
    #region Fields

    #endregion

    #region Methods

    /// <summary>
    /// Method to initialize variables.
    /// </summary>
    protected override void Initilize()
    {
        currentStatus = EnemyStatus.Guard;

        currentWalkSpeed = GameSettings.ArracaLinguasWalkSpeed;
    }

    /// <summary>
    /// Update game logic.
    /// </summary>
    void Update()
    {
        if (currentStatus != EnemyStatus.Attack)
        {
            // Evaluate which status will be choosed.
            EvaluateEnemyStatus();
        }

        // Method to implement enemy status behavior.
        UpdateCurrentEnemyStatus();
    }

    /// <summary>
    /// Detect collision hit.
    /// </summary>
    protected override void OnCollisionHit(Collision2D collision, EnemyStatus nextStatus)
    {
        if (collision.gameObject.tag == GameSettings.PlayerTag)
        {
            currentStatus = nextStatus;
        }
    }

    /// <summary>
    /// Method to evaluate enemy status.
    /// </summary>
    protected override void EvaluateEnemyStatus()
    {
        // Player distance.
        float playerDistance = Vector2.Distance(GameManager.Instance.PlayerObject.transform.position, transform.position);

        // If distance is lower than radius...
        if (playerDistance <= GameSettings.ArracaLinguasTriggerAttackRadius)
        {
            // Chasing player.
            currentStatus = EnemyStatus.Chase;

            // If reach player, than the status change to idle.
            if (playerDistance < GameSettings.EnemyDistanceToReachTarget)
            {
                currentStatus = EnemyStatus.Idle;
            }
        }
        else if (Vector2.Distance(startPosition, transform.position) > 0 && currentStatus != EnemyStatus.ReturnToGuard)
        {
            currentStatus = EnemyStatus.Idle;
        }
    }

    /// <summary>
    /// Method to implement enemy status behavior.
    /// </summary>
    protected override void UpdateCurrentEnemyStatus()
    {
        // If status is chase, than follow player.
        if (currentStatus == EnemyStatus.Chase)
        {
            UpdateChaseStatus(GameManager.Instance.PlayerObject.transform.position);
        }
        // If status is return to guard position, than return to there.
        else if (currentStatus == EnemyStatus.ReturnToGuard)
        {
            UpdateChaseStatus(startPosition);

            if (Vector2.Distance(startPosition, transform.position) < GameSettings.EnemyDistanceToReachTarget)
            {
                currentStatus = EnemyStatus.Guard;
            }
        }
        else if (currentStatus == EnemyStatus.Idle)
        {
            // Return to guard start position.
            StartCoroutine(WaitToChangeStatus(2f, EnemyStatus.ReturnToGuard));
        }
    }

    #endregion
}
