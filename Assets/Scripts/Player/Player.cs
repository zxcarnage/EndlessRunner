using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    public UnityEvent<int> HealthChanged;
    public UnityEvent Died;

    public void ApplyDamage(int damage)
    {
        _health -= damage;
        HealthChanged.Invoke(_health);
        if (_health <= 0)
            Die();
    }

    private void Die()
    {
        Died.Invoke();
    }
}
