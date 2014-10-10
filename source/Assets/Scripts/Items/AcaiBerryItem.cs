using UnityEngine;
using System.Collections;

public class AcaiBerryItem : BaseItem
{
    #region Methods

    /// <summary>
    /// When will use the gold item.
    /// </summary>
    public override void OnUse()
    {
        PlayerMovement.PlayerGameObject.SendMessage("IncreaseSpeed");

        base.OnUse();
    }

    #endregion
}
