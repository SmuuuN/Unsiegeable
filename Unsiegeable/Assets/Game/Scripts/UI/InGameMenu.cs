using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGameMenu : MonoBehaviour
{
    [SerializeField] private Button _restartButton;

    [SerializeField] private Button _exitButton;

    [SerializeField] private Button _pauseButton;

    private void OnEnable()
    {
        _restartButton.onClick.AddListener(Restart);
        _exitButton.onClick.AddListener(Exit);
        _pauseButton.onClick.AddListener(Pause);
    }

    private void OnDisable()
    {
        _restartButton.onClick.RemoveListener(Restart);
        _exitButton.onClick.RemoveListener(Exit);
        _pauseButton.onClick.RemoveListener(Pause);
    }

    private void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    private void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void Pause()
    {
        

        if (Time.timeScale > 0)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }
}
