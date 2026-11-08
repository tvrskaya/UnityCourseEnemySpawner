using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;

    private Vector3 _moveDirection;

    public void Initialize(Vector3 position, Vector3 moveDirection)
    {
        transform.position = position;
        _moveDirection = moveDirection;
    }

    private void Update()
    {
        transform.Translate(_moveDirection * _moveSpeed * Time.deltaTime);
    }
}
