using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{
    [SerializeField] private GameObject losePanel;
    [SerializeField] private Button restartBtn; 
    void Start()
    {
        BallSpawner.OnNotEnoughBalls += ShowScreen;
        restartBtn.onClick.AddListener(Restart);
    }

    private void ShowScreen()
    {
        losePanel.SetActive(true);
        BallSpawner.OnNotEnoughBalls -= ShowScreen;
    }

    private void Restart()
    {
        SceneManager.LoadScene(0);
        restartBtn.onClick.RemoveListener(Restart);
    }
}
