using UnityEngine;

public class CraftingUI : MonoBehaviour
{
    public CraftingSystem craftingSystem;
    public CraftingRecipeSO selectedRecipe; // Assign the crafting recipe in the Inspector

    public void CraftSelectedItem()
    {
        craftingSystem.CraftItem(selectedRecipe);
    }
}
