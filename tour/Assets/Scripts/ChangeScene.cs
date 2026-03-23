using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void SwapScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
