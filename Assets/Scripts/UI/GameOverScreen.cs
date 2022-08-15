using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))] 
public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _exitButton;

    private CanvasGroup _gameOverGroup;

    private void Start()
    {
        _gameOverGroup = GetComponent<CanvasGroup>();
        _gameOverGroup.alpha = 0;
    }

    private void OnEnable()
    {
        _player.Died.AddListener(GameOver);
        _restartButton.onClick.AddListener(Restart);
        _exitButton.onClick.AddListener(Exit);
    }

    private void GameOver()
    {
        Time.timeScale = 0;
        _gameOverGroup.alpha = 1;
    }

    private void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    private void Exit()
    {
        Application.Quit();
    }
}
