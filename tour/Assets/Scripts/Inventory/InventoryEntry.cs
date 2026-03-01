using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryEntry : MonoBehaviour
{
    [SerializeField] Image displayImage;
    public PickupObject objectType;

    public void SetUpEntry(Sprite image, PickupObject pickup)
    {
        displayImage.sprite = image;
        objectType = pickup;
        GetComponentInChildren<TextMeshProUGUI>().text = "" + objectType;
    }
    
    public void TryUse()
    {
        Debug.Log("Tried to use " + objectType);
        if (GameManager.instance.currentPuzzle != null)
        {
            Debug.Log("not null!");
            if (objectType == GameManager.instance.currentPuzzle.puzzleSolution)
            {
                Debug.Log("Solved it!");
                GameManager.instance.currentPuzzle.SolvePuzzle();
            }
        }
    }
}
