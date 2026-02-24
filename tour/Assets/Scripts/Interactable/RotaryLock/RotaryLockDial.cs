using System.Collections;
using UnityEngine;

public class RotaryLockDial : Interactable
{
    [SerializeField] RotaryLock rotaryLock;
    [SerializeField] int placeInOrder;
    [SerializeField] bool increasing;
    bool isTurning = false;
    float delay = 0.2f;
    
    public override void ReactToClick()
    {
        if (isTurning) return;
        isTurning = true;
        rotaryLock.Rotate(placeInOrder, increasing);
        StartCoroutine(WaitForTransition());
    }

    IEnumerator WaitForTransition()
    {
        yield return new WaitForSecondsRealtime(delay);
        isTurning = false;
    }
}
