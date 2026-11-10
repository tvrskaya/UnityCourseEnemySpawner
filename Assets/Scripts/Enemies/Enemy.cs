using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;

    private Transform _target;

    public virtual void Initialize(Vector3 position, Transform target)
    {
        transform.position = position;
        _target = target;
    }

    private void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        transform.position = Vector3.MoveTowards(
                            transform.position,
                            _target.position,
                            _moveSpeed * Time.deltaTime);
    }
}
