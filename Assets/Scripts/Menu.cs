using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private Animator anim;

    private void Awake()
    {
        anim.enabled = false;
        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 0;
    }

    public void StartGame()
    {
        anim.enabled = true;
        StartCoroutine(StartGameCoroutine());
    }

    private IEnumerator StartGameCoroutine()
    {
        yield return new WaitForSeconds(0.36f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
