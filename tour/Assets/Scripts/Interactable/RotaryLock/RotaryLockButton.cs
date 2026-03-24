using System.Collections; // maybe factor out the delay into the main Interactable class 
using UnityEngine;

public class RotaryLockButton : Interactable
{
    [SerializeField] RotaryLock rotaryLock;
    bool isTurning = false;
    float delay = 0.2f;

    public override void ReactToClick()
    {
        if (isTurning) return;
        isTurning = true;
        rotaryLock.TryUnlock();
        //StartCoroutine(WaitForTransition()); // Buggy because of game object setting inactive
    }

    IEnumerator WaitForTransition()
    {
        yield return new WaitForSecondsRealtime(delay);
        isTurning = false;
    }
}
