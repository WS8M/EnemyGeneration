using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private TargetMovement _movement;
    
    public void Init(Transform target)
    {
        _movement.Init(target);
    }
}