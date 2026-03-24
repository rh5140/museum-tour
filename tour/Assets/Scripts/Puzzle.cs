using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public PickupObject puzzleSolution;
    [SerializeField] bool isAdditive;
    [SerializeField] GameObject[] puzzlePart;
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
            foreach (GameObject obj in puzzlePart)
                obj.SetActive(true);
        }
        else
        {
            foreach (GameObject obj in puzzlePart)
                obj.SetActive(false);
        }
        if (reward != null) Invoke("SpawnReward", 0.5f);
    }

    void SpawnReward()
    {
        reward.SetActive(true);
    }
}
