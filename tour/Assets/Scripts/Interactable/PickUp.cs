using UnityEngine;

public class PickUp : Interactable
{
    public override void ReactToClick()
    {
        Debug.Log("Picked up");
    }
}
