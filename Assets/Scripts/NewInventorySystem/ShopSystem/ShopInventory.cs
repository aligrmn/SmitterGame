using System.Collections.Generic;
using UnityEngine;

public class ShopInventory : MonoBehaviour
{
    public List<InventoryItem> shopItems = new List<InventoryItem>();

    // Add an item to the shop
    public void AddShopItem(ItemSO item, int quantity)
    {
        InventoryItem existingItem = shopItems.Find(i => i.item == item);
        if (existingItem != null)
        {
            existingItem.quantity += quantity;
        }
        else
        {
            shopItems.Add(new InventoryItem(item, quantity));
        }
    }

    // Remove an item from the shop
    public bool RemoveShopItem(ItemSO item, int quantity)
    {
        InventoryItem existingItem = shopItems.Find(i => i.item == item);
        if (existingItem != null && existingItem.quantity >= quantity)
        {
            existingItem.quantity -= quantity;
            if (existingItem.quantity == 0)
                shopItems.Remove(existingItem);
            return true;
        }
        return false;
    }

    // Get current quantity of an item in the shop
    public int GetShopItemQuantity(ItemSO item)
    {
        InventoryItem existingItem = shopItems.Find(i => i.item == item);
        return existingItem != null ? existingItem.quantity : 0;
    }
}
