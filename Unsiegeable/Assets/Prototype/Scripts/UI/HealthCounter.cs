using UnityEngine;
using UnityEngine.UI;

public class HealthCounter : MonoBehaviour
{
    [SerializeField] private Castle _objectOfCount;

    [SerializeField] private Text _healthText;

    private void OnEnable()
    {
        _objectOfCount.HealthChanged += DisplayHealth;

        DisplayHealth();
    }

    private void OnDisable()
    {
        _objectOfCount.HealthChanged -= DisplayHealth;
    }

    private void DisplayHealth()
    {
        _healthText.text = $"Health: {_objectOfCount.HealthPoints}";
    }
}
