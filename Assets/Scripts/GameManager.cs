using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject levelCompletelUI;
    [SerializeField] private GameObject endGameUI;
    [SerializeField] private Scene scene;

    private bool isGameEnded = false;

    public void CompleteLevel() => levelCompletelUI.SetActive(true);

    public void EndGame()
    {
        if (isGameEnded == false)
        {
            isGameEnded = true;
            StartCoroutine(EndGameCoroutine());
            StartCoroutine(RestartGameCoroutine());
        }
    }

    private IEnumerator EndGameCoroutine()
    {
        yield return new WaitForSeconds(1f);
        endGameUI.SetActive(true);
    }

    private void Restart() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    private IEnumerator RestartGameCoroutine()
    {
        yield return new WaitForSeconds(2.25f);
        Restart();
    }
}
