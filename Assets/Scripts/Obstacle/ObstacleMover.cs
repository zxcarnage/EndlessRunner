using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    public void MoveObstacle()
    {
        transform.Translate(Vector3.back * _speed * Time.deltaTime);
    }
}
