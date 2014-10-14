using UnityEngine;
using System.Collections;

/// <summary>
/// Enum to define who is the owner of the shot.
/// </summary>
public enum ShotOwnerTag
{
    PlayerShot,
    EnemyShot
}

/// <summary>
/// Enum to define which item is.
/// </summary>
public enum ItemType
{
    AcaiBerry,
    Guarana,
    Gold,
    GoldMother,
    Cassava
}

/// <summary>
/// Enum to define enemy status.
/// </summary>
public enum EnemyStatus
{
    Idle, // do not move.
    Patrol, // moves back and forth.
    Chase, // like patrol, but will come after player if he is closer.
    Shoot, // fires a projectil and tries to keep distance from player.
    Guard, // the priority is staying in an area to stop player.
    Burrower, // an enemy that has invunerable state which allows it to change position around player.
    Blocker, // an enemy that can block some player's attack, but could be 'disarmed'.
    Doppleganger // an enemy who reproduce what player will do.
}