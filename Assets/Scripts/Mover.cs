using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private Transform _target;

    public void Init(Transform target)
    {
        _target = target;
    }

    private void Update()
    {
        if (_target is null)
            return;
        
        Move();
        Rotate();
    }

    private void Move()
    {
        transform.Translate(_moveSpeed * Time.deltaTime * Vector3.forward);
    }

    private void Rotate()
    {
        transform.LookAt(_target);
    }
}