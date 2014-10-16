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
        GameManager.Instance.PlayerWeaponScript.IncreaseShotSpeed();

        base.OnUse();
    }

    #endregion
}
