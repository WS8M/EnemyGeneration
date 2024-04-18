using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private Vector3 _direction;

    public void Init(Vector3 direction)
    {
        _direction = direction;
        transform.LookAt(transform.position + _direction);
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(_moveSpeed * Time.deltaTime * _direction, Space.World);
    }
}