using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public Inventory playerInventory;
    public ShopInventory shopInventory;

    public ItemSO itemToBuyOrSell; // Assign this in the Inspector

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Buy the assigned item
    public void BuySelectedItem(int quantity)
    {
        if (itemToBuyOrSell != null)
        {
            BuyItem(itemToBuyOrSell, quantity);
        }
    }

    // Sell the assigned item
    public void SellSelectedItem(int quantity)
    {
        if (itemToBuyOrSell != null)
        {
            SellItem(itemToBuyOrSell, quantity);
        }
    }

    // Buy a specific item from the shop
    private void BuyItem(ItemSO item, int quantity)
    {
        int shopStock = shopInventory.GetShopItemQuantity(item);
        if (shopStock >= quantity)
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

    // Sell a specific item to the shop
    private void SellItem(ItemSO item, int quantity)
    {
        int playerStock = playerInventory.GetItemQuantity(item);
        if (playerStock >= quantity)
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
