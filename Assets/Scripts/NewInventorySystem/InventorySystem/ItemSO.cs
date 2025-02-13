using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Item/Create New Item")]

public class ItemSO : ScriptableObject
{
    public string itemName;
    public int itemValue;

    public Sprite ItemIcon;
}
