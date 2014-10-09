using UnityEngine;
using System.Collections;
using System;

public abstract class BaseItem : BaseScript
{
    #region Fields

    /// <summary>
    /// The type of item.
    /// </summary>
    protected ItemType itemType;

    #endregion

    #region Properties

    /// <summary>
    /// Get the item type.
    /// </summary>
    public ItemType ItemType
    {
        get { return itemType; }
    }

    /// <summary>
    /// Set if game object is active.
    /// </summary>
    private bool Active
    {
        set { gameObject.SetActive(value); }
    }

    #endregion

    #region Methods

    void Start()
    {
        string itemName = gameObject.name.Replace(" Item", "");

        itemType = (ItemType)Enum.Parse(typeof(ItemType), itemName);
    }

    /// <summary>
    /// When item were collected.
    /// </summary>
    public void OnCollected(Transform parent)
    {
        transform.parent = parent;

        Active = false;
    }

    /// <summary>
    /// When will use the item.
    /// </summary>
    public virtual void OnUse()
    {
        print("Utilizou um " + gameObject.name);

        transform.parent = null;
    }

    #endregion
}
