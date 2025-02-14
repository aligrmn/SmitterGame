using UnityEngine;

public class ShopUI : MonoBehaviour
{
    public Inventory playerInventory;  // Assign the player's inventory in Inspector
    public Inventory shopInventory;    // Assign the shop's inventory in Inspector
    public ItemSO itemToBuyOrSell;     // Assign a specific ItemSO in Inspector

    public void BuyOne()
    {
        BuyItem(itemToBuyOrSell, 1);
    }

    public void BuyFive()
    {
        BuyItem(itemToBuyOrSell, 5);
    }

    public void SellOne()
    {
        SellItem(itemToBuyOrSell, 1);
    }

    public void SellFive()
    {
        SellItem(itemToBuyOrSell, 5);
    }

    private void BuyItem(ItemSO item, int quantity)
    {
        if (shopInventory.RemoveItem(item, quantity)) // Check if shop has enough stock
        {
            playerInventory.AddItem(item, quantity);
            Debug.Log($"Bought {quantity} {item.itemName}");
        }
        else
        {
            Debug.Log("Not enough stock in the shop!");
        }
    }

    private void SellItem(ItemSO item, int quantity)
    {
        if (playerInventory.RemoveItem(item, quantity)) // Check if player has enough items
        {
            shopInventory.AddItem(item, quantity);
            Debug.Log($"Sold {quantity} {item.itemName}");
        }
        else
        {
            Debug.Log("Not enough items to sell!");
        }
    }
}
