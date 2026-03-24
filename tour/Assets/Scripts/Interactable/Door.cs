using System.Collections;
using UnityEngine;

public class Door : Interactable
{
    [SerializeField] GameObject camera1;
    [SerializeField] GameObject camera2;
    bool isSwapping = false;
    float transitionTime = 1f;

    public override void ReactToClick()
    {
        if (isSwapping) return;
        isSwapping = true;
        if (camera1.activeSelf)
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
        else
        {
            camera2.SetActive(false);
            camera1.SetActive(true);
        }
        StartCoroutine(WaitForTransition());
        Debug.Log(gameObject.name);
    }
    
    IEnumerator WaitForTransition()
    {
        yield return new WaitForSecondsRealtime(transitionTime);
        isSwapping = false;
    }
}
