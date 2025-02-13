using UnityEngine;

public class ShopSystem : MonoBehaviour
{
    public Inventory playerInventory;
    public ShopInventory shopInventory;

    public void BuyItem(ItemSO item, int quantity)
    {
        if (shopInventory.GetShopItemQuantity(item) >= quantity)
        {
            shopInventory.RemoveShopItem(item, quantity);
            playerInventory.AddItem(item, quantity);
            Debug.Log("Bought " + quantity + " " + item.itemName);
        }
        else
        {
            Debug.Log("Not enough stock in shop!");
        }
    }

    public void SellItem(ItemSO item, int quantity)
    {
        if (playerInventory.GetItemQuantity(item) >= quantity)
        {
            playerInventory.RemoveItem(item, quantity);
            shopInventory.AddShopItem(item, quantity);
            Debug.Log("Sold " + quantity + " " + item.itemName);
        }
        else
        {
            Debug.Log("Not enough items to sell!");
        }
    }
}
