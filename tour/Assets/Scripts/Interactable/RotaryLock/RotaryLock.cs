using TMPro;
using UnityEngine;

public class RotaryLock : MonoBehaviour
{
    [SerializeField] int code1;
    [SerializeField] int code2;
    [SerializeField] int code3;

    [SerializeField] TextMeshPro num1Display;
    [SerializeField] TextMeshPro num2Display;
    [SerializeField] TextMeshPro num3Display;

    int num1;
    int num2;
    int num3;

    [SerializeField] GameObject[] door;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        num1 = int.Parse(num1Display.text);
        num2 = int.Parse(num2Display.text);
        num3 = int.Parse(num3Display.text);
    }

    public void Rotate(int num, bool increasing)
    {
        int newValue;
        switch (num)
        {
            case 1: 
                newValue = NumFromRotation(num1, increasing);
                num1Display.text = newValue.ToString();
                num1 = newValue;
                break;
            case 2:
                newValue = NumFromRotation(num2, increasing);
                num2Display.text = newValue.ToString();
                num2 = newValue;
                break;
            case 3:
                newValue = NumFromRotation(num3, increasing);
                num3Display.text = newValue.ToString();
                num3 = newValue;
                break;
        }
    }

    int NumFromRotation(int value, bool increasing)
    {
        int newValue;
        if (increasing) // there's definitely a more elegant way to loop numbers
        {
            newValue = (value + 1) % 10;
        }
        else
        {
            newValue = value - 1;
            if (newValue < 0) newValue = 9;
        }
        return newValue;
    }

    public void TryUnlock()
    {
        Debug.Log("TRY UNLOCK..");
        if (code1 == num1 && code2 == num2 && code3 == num3)
        {
            Open();
        }
    }

    void Open()
    {
        foreach (GameObject part in door)
        {
            part.SetActive(false);
        }
        gameObject.SetActive(false);
    }
}
