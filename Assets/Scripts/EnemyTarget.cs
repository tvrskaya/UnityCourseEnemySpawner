using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    [SerializeField] private Vector3 _startPoint;
    [SerializeField] private Vector3 _endPoint;
    [SerializeField] private float _moveSpeed = 10f;

    private Vector3 _currentTargetPoint;

    private void Start()
    {
        _currentTargetPoint = _startPoint;
        transform.position = _currentTargetPoint;
    }

    private void Update()
    {
        UpdateCurrentTargetPoint();
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position,
                                                _currentTargetPoint,
                                                _moveSpeed * Time.deltaTime);
    }

    private void UpdateCurrentTargetPoint()
    {
        if (_currentTargetPoint == transform.position)
        {
            if (_currentTargetPoint == _startPoint)
            {
                _currentTargetPoint = _endPoint;
            }
            else
            {
                _currentTargetPoint = _startPoint;
            }
        }
    }
}
