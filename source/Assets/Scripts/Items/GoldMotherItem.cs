using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class GoldMotherItem : BaseItem
{
    #region Methods

    /// <summary>
    /// When will use the gold item.
    /// </summary>
    public override void OnUse()
    {
        List<GameObject> golds = GameObject.FindGameObjectsWithTag(GameSettings.GoldTag).ToList();

        print("Existem " + golds.Count + " golds no cenário!");

        golds.ForEach(g =>
        {
            g.renderer.enabled = true;
            g.collider2D.enabled = true;
        });

        base.OnUse();
    }

    #endregion
}
