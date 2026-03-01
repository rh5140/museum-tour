using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player player;
    public Inventory inventory;
    public ZoomIn currentPuzzle;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
}
