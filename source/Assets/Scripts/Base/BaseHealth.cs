using UnityEngine;
using System.Collections;

public class BaseHealth : BaseScript
{
    #region Fields

    /// <summary>
    /// The shot tag to compare trigger collision.
    /// </summary>
    [SerializeField]
    private ShotTag shotTag;

    /// <summary>
    /// Current health.
    /// </summary>
    protected float currentHeath;

    #endregion

    #region Methods

    /// <summary>
    /// When trigger is enabled detect other collider against this one.
    /// </summary>
    /// <param name="collider">The collider.</param>
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == shotTag.ToString())
        {
            BaseShot baseShot = collider.GetComponent<BaseShot>();

            Damage(baseShot.ShotDamage);
        }
    }

    /// <summary>
    /// Set damage.
    /// </summary>
    /// <param name="damage">The damage value.</param>
    protected void Damage(int damage)
    {
        print(string.Format("{0} WAS HIT!", gameObject.name));

        currentHeath -= damage;

        if (currentHeath <= 0)
        {
            print(gameObject.name + " died!");

            //gameObject.SetActive(false);
        }
    }

    #endregion
}
