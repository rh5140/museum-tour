using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject inventoryEntry;
    
    public void AddToInventory(Sprite itemImage)
    {
        GameObject newEntry = Instantiate(inventoryEntry, transform);
        newEntry.GetComponent<Image>().sprite = itemImage;
    }
}
