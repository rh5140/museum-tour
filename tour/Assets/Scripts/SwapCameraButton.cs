using UnityEngine;

public class SwapCameraButton : MonoBehaviour
{
    [SerializeField] GameObject currCamera;
    [SerializeField] GameObject nextCamera;

    public void SwapCamera()
    {
        nextCamera.SetActive(true);
        currCamera.SetActive(false);
    }
}
