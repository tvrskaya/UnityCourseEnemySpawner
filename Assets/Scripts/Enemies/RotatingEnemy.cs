using UnityEngine;

public class RotatingEnemy : Enemy
{
    [SerializeField] private float _rotationSpeed = 5f;

    protected override void Move()
    {
        base.Move();
        transform.Rotate(Vector3.up, _rotationSpeed);
    }
}
