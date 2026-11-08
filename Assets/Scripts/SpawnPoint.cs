using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private readonly float MaxDirectionValue = 1f;
    private readonly float MinDirectionValue = -1f;
    private readonly int DirectionValueY = 0;
    private readonly int ModelPositionScale = 2; 

    [SerializeField] private EnemyPool _enemyPool;

    public void Spawn()
    {
        var enemy = _enemyPool.Get();

        float scaledPositionY = transform.position.y * ModelPositionScale + enemy.transform.localScale.y;
        var enemyPosition = new Vector3(transform.position.x, scaledPositionY, transform.position.z);

        var directionX = Random.Range(MinDirectionValue, MaxDirectionValue);
        var directionY = Random.Range(MinDirectionValue, MaxDirectionValue);

        var enemyMoveDirection = new Vector3(directionX, DirectionValueY, directionY);

        enemy.Initialize(enemyPosition, enemyMoveDirection);
    }
}
