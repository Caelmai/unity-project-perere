using UnityEngine;
using System.Collections;

public class GuaranaItem : BaseItem
{
    #region Fields

    /// <summary>
    /// Invoke original renderer.
    /// </summary>
    protected float message;

    #endregion

    #region Methods

    /// <summary>
    /// When will use the gold item.
    /// </summary>
    public override void OnUse()
    {
        GameManager.Instance.PlayerMovementScript.IncreaseSpeed();

        base.OnUse();
    }

    #endregion
}
