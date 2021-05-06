using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    [SerializeField] private GameObject _inGameMenu;
    [SerializeField] private GameObject _deathScreen;

    [SerializeField] private Castle _castle;

    [SerializeField] private Button _homeButton;
    [SerializeField] private Button _restartButton;

    [SerializeField] private GameObject _catapult;

    private void OnEnable()
    {
        _castle.DeathHappened += OnDeathHappened;

        _homeButton.onClick.AddListener(ReturnHome);
        _restartButton.onClick.AddListener(Restart);
    }

    private void OnDisable()
    {
        _castle.DeathHappened -= OnDeathHappened;

        _homeButton.onClick.RemoveListener(ReturnHome);
        _restartButton.onClick.RemoveListener(Restart);
    }

    private void OnDeathHappened()
    {

        Time.timeScale = 0f;

        _inGameMenu.SetActive(false);

        _deathScreen.SetActive(true);

        _catapult.SetActive(false);

    }

    private void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    private void ReturnHome()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
