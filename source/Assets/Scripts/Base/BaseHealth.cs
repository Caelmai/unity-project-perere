using UnityEngine;
using System.Collections;

public abstract class BaseHealth : BaseScript
{
    #region Fields

    /// <summary>
    /// Current health.
    /// </summary>
    protected int currentHeath;

    /// <summary>
    /// The shot tag to compare trigger collision.
    /// </summary>
    [SerializeField]
    private ShotOwnerTag shotOwnerTag;

    #endregion

    #region Methods

    /// <summary>
    /// When trigger is enabled detect other collider against this one.
    /// </summary>
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == shotOwnerTag.ToString())
        {
            BaseShot shot = collider.GetComponent<BaseShot>();

            Damage(shot.Damage);

            shot.Active = false;
        }
    }

    /// <summary>
    /// Set damage.
    /// </summary>
    /// <param name="damage">The damage value.</param>
    protected void Damage(int damage)
    {
        currentHeath -= damage;

        if (currentHeath <= 0)
        {
            OnDeath();
        }
    }

    /// <summary>
    /// A method to be implement by each character health script.
    /// </summary>
    protected abstract void OnDeath();

    #endregion
}
