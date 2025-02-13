using UnityEngine;

public class CraftingSystem : MonoBehaviour
{
    public Inventory playerInventory;

    public void CraftItem(CraftingRecipeSO recipe)
    {
        foreach (var ingredient in recipe.ingredients)
        {
            if (playerInventory.GetItemQuantity(ingredient.item) < ingredient.quantity)
            {
                Debug.Log("Not enough materials!");
                return;
            }
        }

        foreach (var ingredient in recipe.ingredients)
        {
            playerInventory.RemoveItem(ingredient.item, ingredient.quantity);
        }

        playerInventory.AddItem(recipe.outputItem, recipe.outputQuantity);
        Debug.Log("Crafted " + recipe.outputQuantity + " " + recipe.outputItem.itemName);
    }
}
