using UnityEngine;

public class Waypoints : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    
    public int CountOfPoints => _points.Length;
    
    public Vector3 GetPointPosition(int pointIndex) => _points[pointIndex].position;
}