using System.Collections;
using UnityEngine;

public class ZoomIn : Interactable
{
    [SerializeField] GameObject roomCamera;
    [SerializeField] GameObject objectCamera;
    [SerializeField] GameObject newInteractable;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    bool isSwapping = false;
    bool isZoomed = false;
    float transitionTime = 1f;

    public override void ReactToClick()
    {
        if (isSwapping) return;
        ZoomCamera();
    }

    void ZoomCamera()
    {
        isSwapping = true;
        if (newInteractable != null) newInteractable.SetActive(!isZoomed);
        roomCamera.SetActive(isZoomed);
        objectCamera.SetActive(!isZoomed);
        isZoomed = !isZoomed;
        StartCoroutine(WaitForTransition());
    }
    
    IEnumerator WaitForTransition()
    {
        yield return new WaitForSecondsRealtime(transitionTime);
        isSwapping = false;
    }
}
