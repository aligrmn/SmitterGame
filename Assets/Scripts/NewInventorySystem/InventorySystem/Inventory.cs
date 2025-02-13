using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventoryItem
{
    public ItemSO item;
    public int quantity;

    public InventoryItem(ItemSO item, int quantity)
    {
        this.item = item;
        this.quantity = quantity;
    }
}

public class Inventory : MonoBehaviour
{
    public List<InventoryItem> items = new List<InventoryItem>();

    // Get current quantity of an item
    public int GetItemQuantity(ItemSO item)
    {
        InventoryItem existingItem = items.Find(i => i.item == item);
        return existingItem != null ? existingItem.quantity : 0;
    }

    // Add an item to inventory
    public void AddItem(ItemSO item, int quantity)
    {
        InventoryItem existingItem = items.Find(i => i.item == item);
        if (existingItem != null)
        {
            existingItem.quantity += quantity;
        }
        else
        {
            items.Add(new InventoryItem(item, quantity));
        }
    }

    // Remove an item from inventory
    public bool RemoveItem(ItemSO item, int quantity)
    {
        InventoryItem existingItem = items.Find(i => i.item == item);
        if (existingItem != null && existingItem.quantity >= quantity)
        {
            existingItem.quantity -= quantity;
            if (existingItem.quantity == 0)
                items.Remove(existingItem);
            return true;
        }
        return false;
    }
}
