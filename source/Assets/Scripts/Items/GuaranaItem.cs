using UnityEngine;
using System.Collections;

public class GuaranaItem : BaseItem
{
    #region Methods

    /// <summary>
    /// When will use the gold item.
    /// </summary>
    public override void OnUse()
    {
        PlayerMovement.PlayerGameObject.SendMessage("IncreaseHealth");

        base.OnUse();
    }

    #endregion
}
