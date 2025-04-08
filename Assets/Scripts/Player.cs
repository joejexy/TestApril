using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // Speed of the player
    [SerializeField] private float jumpForce = 5f; // Jump force of the player
    [SerializeField] private LayerMask hitLayer; // Layer mask for obstacle detection
    [SerializeField] private Rigidbody rb; // Layer mask for obstacle detection

    private int distanceTraveled;

    // Update is called once per frame
    void Update()
    {
        // store the distance traveled
        distanceTraveled += (int)(speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player has collided with an obstacle
        if (collision.gameObject.layer == LayerMask.NameToLayer("Obstacle"))
        {
            PlayerPrefs.SetInt("Highscore", distanceTraveled); // Save the high score
            distanceTraveled = 0; // Reset the distance traveled
            GameManager.instance.GameOver(); // Call the GameOver method from GameManager
        }
    }
}
