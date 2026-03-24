using System.Collections;
using UnityEngine;

public class CameraSetup : MonoBehaviour
{
    [SerializeField] float transitionTime = 2f;
    [SerializeField] GameObject arrowCanvas;

    void OnEnable()
    {
        DeactivateArrows();
        StartCoroutine(WaitForTransition());
    }

    IEnumerator WaitForTransition()
    {
        yield return new WaitForSecondsRealtime(transitionTime);
        arrowCanvas.SetActive(true);
    }

    public void DeactivateArrows()
    {
        arrowCanvas.SetActive(false);
    }
}
