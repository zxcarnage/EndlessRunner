using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Healtbar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _healthbarText;

    private Slider _healthbar;

    private void Awake()
    {
        _healthbar = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _player.HealthChanged.AddListener(ChangeHealthbar);
    }

    private void ChangeHealthbar(int health)
    {
        _healthbar.value = health;
        _healthbarText.text = health.ToString();
    }
}
