using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject inventoryEntry;
    
    public void AddToInventory(Sprite itemImage, PickupObject objectType)
    {
        GameObject newEntry = Instantiate(inventoryEntry, transform);
        newEntry.GetComponent<Image>().sprite = itemImage;
        newEntry.GetComponent<InventoryEntry>().objectType = objectType;
    }
}
