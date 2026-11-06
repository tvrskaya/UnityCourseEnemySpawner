using UnityEngine;

public class Spawner : MonoBehaviour
{
    [ContextMenuItem("Yuuuriii", nameof(Spawn))]

    private readonly float _maxRotation = 360f;
    private readonly float _minRotation = 0f;

    [SerializeField] private EnemyPool _enemyPool;

    public void Spawn()
    {
        var enemy = _enemyPool.Get();

        enemy.transform.position = new Vector3(transform.position.x, transform.position.y * 2 + enemy.transform.localScale.y, transform.position.z);

        var rotation = Random.Range(_minRotation, _maxRotation);
        enemy.transform.rotation = Quaternion.Euler(0, rotation, 0);
    }
}
