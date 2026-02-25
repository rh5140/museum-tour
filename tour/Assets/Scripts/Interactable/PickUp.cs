using UnityEngine;

public class PickUp : Interactable
{
    [SerializeField] Sprite image;
    [SerializeField] PickupObject objectType;

    public override void ReactToClick()
    {
        GameManager.instance.inventory.AddToInventory(image, objectType); // currently doesn't pass any GameObject data but should later
        gameObject.SetActive(false);
    }
}
