using UnityEngine;
using System.Collections;

public abstract class BaseHealth : BaseScript
{
    #region Fields

    /// <summary>
    /// Default recover color method name.
    /// </summary>
    protected const string OriginalRendererMethod = "SetOriginalRenderer";

    /// <summary>
    /// The sprite renderer.
    /// </summary>
    protected SpriteRenderer spriteRenderer;

    /// <summary>
    /// Current health.
    /// </summary>
    protected int currentHeath;

    /// <summary>
    /// The shot tag to compare trigger collision.
    /// </summary>
    [SerializeField]
    private ShotOwnerTag shotOwnerTag = 0;

    /// <summary>
    /// Was hit?.
    /// </summary>
    protected bool wasHit;

    /// <summary>
    /// Invoke callback timer.
    /// </summary>
    protected float updateRendererEffectTime = 0f;

    /// <summary>
    /// Invoke original renderer.
    /// </summary>
    protected float invokeOriginalRenderer;

    #endregion

    #region Methods

    /// <summary>
    /// Called when script start.
    /// </summary>
    void Start()
    {
        spriteRenderer = (SpriteRenderer)renderer;

        wasHit = false;

        Starting();
    }

    /// <summary>
    /// Update game logic.
    /// </summary>
    void Update()
    {
        if (wasHit)
        {
            updateRendererEffectTime += Time.deltaTime;

            if (updateRendererEffectTime > GameSettings.UpdateRendererEffectTime)
            {
                updateRendererEffectTime = 0;

                Updating();
            }
        }
    }

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

        OnHit();

        if (currentHeath <= 0)
        {
            OnDeath();
        }
    }

    /// <summary>
    /// A method to be implement by each character health script when hit.
    /// </summary>
    protected virtual void OnHit()
    {
        wasHit = true;

        Invoke(OriginalRendererMethod, invokeOriginalRenderer);
    }

    /// <summary>
    /// A method to return renderer to orginal setting.
    /// </summary>
    protected virtual void SetOriginalRenderer()
    {
        wasHit = false;
    }

    /// <summary>
    /// A method to initialize variables.
    /// </summary>
    protected abstract void Starting();

    /// <summary>
    /// A method to update game logic.
    /// </summary>
    protected abstract void Updating();

    /// <summary>
    /// A method to be implement by each character health script when die.
    /// </summary>
    protected abstract void OnDeath();

    #endregion
}
