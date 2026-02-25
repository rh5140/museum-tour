using TMPro;
using UnityEngine;

public class InventoryEntry : MonoBehaviour
{
    public PickupObject objectType;
    void Awake()
    {
        GetComponentInChildren<TextMeshProUGUI>().text = "" + objectType;
    }
    
    public void TryUse()
    {
        Debug.Log("Tried to use " + objectType);
    }
}
