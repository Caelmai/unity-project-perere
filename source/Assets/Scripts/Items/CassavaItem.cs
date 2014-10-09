using UnityEngine;
using System.Collections;

public class CassavaItem : BaseItem
{
    #region Methods

    /// <summary>
    /// When will use the gold item.
    /// </summary>
    public override void OnUse()
    {
        player.GetComponentInChildren<PlayerWeapon>().IncreaseWeapon();

        base.OnUse();
    }

    #endregion
}
