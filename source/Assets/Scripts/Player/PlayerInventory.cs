using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PlayerInventory : BaseScript
{
    #region Fields

    /// <summary>
    /// The list of collected items.
    /// </summary>
    private List<BaseItem> collectedItems = new List<BaseItem>();

    /// <summary>
    /// Quantity of gold.
    /// </summary>
    private int goldAmount;

    #endregion

    #region Methods

    /// <summary>
    /// Update game logic.
    /// </summary>
    void Update()
    {
        BaseItem selectedItem = null;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedItem = collectedItems.FirstOrDefault(s => s.ItemType == ItemType.GoldMother);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectedItem = collectedItems.FirstOrDefault(s => s.ItemType == ItemType.AcaiBerry);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            selectedItem = collectedItems.FirstOrDefault(s => s.ItemType == ItemType.Guarana);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            selectedItem = collectedItems.FirstOrDefault(s => s.ItemType == ItemType.Cassava);
        }

        if (selectedItem != null)
        {
            particleEmitter.Emit();

            selectedItem.OnUse();

            collectedItems.Remove(selectedItem);
        }
    }

    /// <summary>
    /// When trigger is enabled, it detect when player is catching items.
    /// </summary>
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == GameSettings.GoldTag)
        {
            collider.gameObject.SetActive(false);

            goldAmount++;
        }
        else if (collider.tag == GameSettings.ItemTag)
        {
            collider.SendMessage("OnCollected", transform);

            collectedItems.Add(collider.GetComponent<BaseItem>());
        }
    }

    /// <summary>
    /// Draw status.
    /// </summary>
    void OnGUI()
    {
        GUI.Label(new Rect(20, 40, 120, 40), "GOLD: " + goldAmount);

        GUI.Label(new Rect(20, 60, 120, 40), string.Format("GoldMother: {0}", collectedItems.Where(s => s.ItemType == ItemType.GoldMother).Count()));
        GUI.Label(new Rect(20, 80, 120, 40), string.Format("AcaiBerry: {0}", collectedItems.Where(s => s.ItemType == ItemType.AcaiBerry).Count()));
        GUI.Label(new Rect(20, 100, 120, 40), string.Format("Guarana: {0}", collectedItems.Where(s => s.ItemType == ItemType.Guarana).Count()));
        GUI.Label(new Rect(20, 120, 120, 40), string.Format("Cassava: {0}", collectedItems.Where(s => s.ItemType == ItemType.Cassava).Count()));
    }

    #endregion
}
