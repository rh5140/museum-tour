using UnityEngine;

public class PickUp : Interactable
{
    [SerializeField] Sprite image;
    [SerializeField] PickupObject objectType;
    [SerializeField] GameObject obj;

    public override void ReactToClick()
    {
        GameManager.instance.inventory.AddToInventory(image, objectType);
        obj.SetActive(false);
        gameObject.SetActive(false);
    }
}
