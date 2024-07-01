using UnityEngine;

public class MoverByWaypoints : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Waypoints _waypoints;

    private int _currentWaypointIndex = 0;
    
    private void Update()
    {
        if (_waypoints.GetPointPosition(_currentWaypointIndex) == transform.position) 
            _currentWaypointIndex = (_currentWaypointIndex + 1) % _waypoints.CountOfPoints;

        transform.position = Vector3.MoveTowards(
            transform.position,
            _waypoints.GetPointPosition(_currentWaypointIndex), 
            _moveSpeed * Time.deltaTime);
    }
}