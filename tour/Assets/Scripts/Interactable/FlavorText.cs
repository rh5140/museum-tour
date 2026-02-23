using UnityEngine;

public class FlavorText : Interactable
{
    [SerializeField] string flavorText = "Clicked!";
    public override void ReactToClick()
    {
        Debug.Log(flavorText);
    }
}
