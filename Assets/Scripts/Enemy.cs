using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Mover _movement;
    
    public void Init(Vector3 direction)
    {
        _movement.Init(direction);
    }
}