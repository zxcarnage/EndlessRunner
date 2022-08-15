using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _stepSize;
    [SerializeField] private float _maxWide;
    [SerializeField] private float _minWide;

    private Vector3 _target;

    private void Start()
    {
        _target = transform.position;
    }

    private void Update()
    {
        if (transform.position != _target)
            transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
    }

    public void MoveRight()
    {
        TrySetTarget(_stepSize);
    }

    public void MoveLeft()
    {
        TrySetTarget(-_stepSize);
    }

    private void TrySetTarget(float stepSize)
    {
        if (_target.x + stepSize <= _maxWide && _target.x + stepSize >= _minWide)
            _target = new Vector3(_target.x + stepSize, _target.y, _target.z);
        
    }
}
