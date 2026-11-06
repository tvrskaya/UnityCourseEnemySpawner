using UnityEngine;
using UnityEngine.Pool;

public class EnemyPool : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private int _poolCapacity = 10;
    [SerializeField] private int _poolMaxSize = 10;

    private ObjectPool<Enemy> _enemyPool;

    public void Awake()
    {
        _enemyPool = new ObjectPool<Enemy>(
            createFunc: () => Object.Instantiate(_enemyPrefab),
            actionOnGet: (Enemy enemy) => ActionOnGet(enemy.gameObject),
            actionOnRelease: (Enemy enemy) => enemy.gameObject.SetActive(false),
            actionOnDestroy: (Enemy enemy) => Object.Destroy(enemy.gameObject),
            collectionCheck: true,
            defaultCapacity: _poolCapacity,
            maxSize: _poolMaxSize
        );
    }

    public Enemy Get()
    {
        return _enemyPool.Get();
    }

    private void ActionOnGet(GameObject obj)
    {
        obj.transform.position = Vector3.zero;
        obj.transform.rotation = Quaternion.identity;

        obj.SetActive(true);
    }

}
