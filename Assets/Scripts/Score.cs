using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Text score;

    private void Update() => score.text = player.position.z.ToString("0");
}
