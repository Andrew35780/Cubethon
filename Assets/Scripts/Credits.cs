using UnityEngine;

public class Credits : MonoBehaviour
{
    [SerializeField] private GameObject creditsUI;

    private void Start() => creditsUI.SetActive(true);

    public void QuitFromGame() => Application.Quit();
}
