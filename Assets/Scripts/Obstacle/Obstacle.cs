using UnityEngine;

[RequireComponent(typeof(ObstacleMover))]
public class Obstacle : MonoBehaviour
{
    private ObstacleMover _mover;

    private void Start()
    {
        _mover = GetComponent<ObstacleMover>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Player player))
        {
            player.ApplyDamage(10);
        }
        Die();
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        _mover.MoveObstacle();
    }
}
