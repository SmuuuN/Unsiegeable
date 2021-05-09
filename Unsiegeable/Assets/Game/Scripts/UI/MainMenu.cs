using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button _playButton;

    [SerializeField] private Button _exitButton;

    private void OnEnable()
    {
        _playButton.onClick.AddListener(Play);
        _exitButton.onClick.AddListener(Exit);
    }

    private void OnDisable()
    {
        _playButton.onClick.RemoveListener(Play);
        _exitButton.onClick.RemoveListener(Exit);
    }

    private void Play()
    {
        SceneManager.LoadScene("Game");
    }

    private void Exit()
    {
        Application.Quit();
    }
}
