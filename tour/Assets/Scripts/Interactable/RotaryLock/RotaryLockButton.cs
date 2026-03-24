using System.Collections; // maybe factor out the delay into the main Interactable class 
using UnityEngine;

public class RotaryLockButton : Interactable
{
    [SerializeField] RotaryLock rotaryLock;
    float delay = 0.2f;

    public override void ReactToClick()
    {
        rotaryLock.TryUnlock();
        //StartCoroutine(WaitForTransition()); // Buggy because of game object setting inactive
    }

    IEnumerator WaitForTransition()
    {
        yield return new WaitForSecondsRealtime(delay);
    }
}
