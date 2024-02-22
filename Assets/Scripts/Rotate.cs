using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.2f;


    void Update()
    {
        transform.Rotate(0, 0, 360 * speed * Time.deltaTime);
    }
}
