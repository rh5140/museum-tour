using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public PickupObject puzzleSolution;
    [SerializeField] bool isAdditive;
    [SerializeField] GameObject puzzlePart;
    [SerializeField] GameObject reward;

    void OnEnable()
    {
        GameManager.instance.currentPuzzle = this;
    }

    void OnDisable()
    {
        GameManager.instance.currentPuzzle = null;
    }

    public void SolvePuzzle()
    {
        if (isAdditive)
        {
            puzzlePart.SetActive(true);
        }
        else
        {
            puzzlePart.SetActive(false);
        }
        Invoke("SpawnReward", 1f);
    }

    void SpawnReward()
    {
        reward.SetActive(true);
    }
}
