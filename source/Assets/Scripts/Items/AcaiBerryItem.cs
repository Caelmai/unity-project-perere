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
        GameManager.Instance.PlayerHealthScript.IncreaseHealth();

        base.OnUse();
    }

    #endregion
}
