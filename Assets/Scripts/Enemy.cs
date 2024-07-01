using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Mover _mover;
    
    public void Init(Transform targetTransform)
    {
        _mover.Init(targetTransform);
    }
}