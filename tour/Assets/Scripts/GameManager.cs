using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] Player player;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
}
