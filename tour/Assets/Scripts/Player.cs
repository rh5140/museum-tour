using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Started!");
    }

    public void Interact(InputAction.CallbackContext context)
    {
        RaycastHit hit;
        Ray rayOrigin = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        if (Physics.Raycast(rayOrigin, out hit))
        {
            Interactable interactable = hit.transform.gameObject.GetComponent<Interactable>();
            if (interactable != null)
            {
                interactable.ReactToClick();
            }
        }
    }
}
