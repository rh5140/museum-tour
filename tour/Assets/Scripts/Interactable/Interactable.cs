using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public virtual void ReactToClick()
    {
        Debug.Log("Abstract class; need to use inherited class instead");
    }
}
