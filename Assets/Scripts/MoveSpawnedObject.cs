using UnityEngine;

public class MoveSpawnedObject : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // Speed of the object

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speed; // Move the object to the left at a speed of 5 units per second
    }
}
