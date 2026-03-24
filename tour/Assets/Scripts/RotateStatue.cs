using UnityEngine;

public class RotateStatue : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        transform.Rotate(0,speed * Time.deltaTime,0);
    }
}
