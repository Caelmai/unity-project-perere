using UnityEngine;
using System.Collections;

public class BaseHealth : MonoBehaviour
{
    #region Fields

    /// <summary>
    /// The health.
    /// </summary>
    [SerializeField]
    private int health;

    /// <summary>
    /// The initial health.
    /// </summary>
    private int initialHealth;

    #endregion

    #region Methods

    public void Damage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            print(gameObject.name + " died!");
        }
    }

    #endregion
}
