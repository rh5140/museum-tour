using UnityEngine;

public class PickUp : Interactable
{
    [SerializeField] Sprite image;

    public override void ReactToClick()
    {
        GameManager.instance.inventory.AddToInventory(image); // currently doesn't pass any GameObject data but should later
        gameObject.SetActive(false);
    }
}
