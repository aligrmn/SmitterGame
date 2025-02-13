using UnityEngine;

[CreateAssetMenu(fileName = "New Crafting Recipe", menuName = "Crafting/Recipe")]
public class CraftingRecipeSO : ScriptableObject
{
    public InventoryItem[] ingredients;
    public ItemSO outputItem;
    public int outputQuantity;
}
