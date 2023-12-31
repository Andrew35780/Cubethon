using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
