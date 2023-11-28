using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private PlayerMovement movement;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.CompleteLevel();
            movement.enabled = false;
        }
    }
}
