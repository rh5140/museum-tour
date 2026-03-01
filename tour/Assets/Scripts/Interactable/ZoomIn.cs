using System.Collections;
using UnityEngine;

public class ZoomIn : Interactable
{
    [SerializeField] GameObject roomCamera;
    [SerializeField] GameObject objectCamera;
    [SerializeField] GameObject newInteractable;
    public PickupObject puzzleSolution;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    bool isSwapping = false;
    bool isZoomed = false;
    float transitionTime = 1f;

    public override void ReactToClick()
    {
        if (isSwapping) return;
        ZoomCamera();
    }

    public void SolvePuzzle()
    {
        // Temporary..
        gameObject.SetActive(false);
    }

    void ZoomCamera()
    {
        isSwapping = true;
        if (newInteractable != null) newInteractable.SetActive(!isZoomed);
        roomCamera.SetActive(isZoomed);
        objectCamera.SetActive(!isZoomed);
        isZoomed = !isZoomed;
        if (isZoomed)
        {
            GameManager.instance.currentPuzzle = this;
        }
        else
        {
            GameManager.instance.currentPuzzle = null;
        }
        StartCoroutine(WaitForTransition());
    }
    
    IEnumerator WaitForTransition()
    {
        yield return new WaitForSecondsRealtime(transitionTime);
        isSwapping = false;
    }
}
