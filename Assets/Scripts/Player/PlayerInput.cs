using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMover _mover;

    private void Start()
    {
        _mover = GetComponent<PlayerMover>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
            _mover.MoveRight();

        if (Input.GetKeyDown(KeyCode.A))
            _mover.MoveLeft();
    }
}
