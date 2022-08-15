using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private float _spawnTime;

    private Transform[] _spawnPoints;
    private float _elapsedTime;

    private void Start()
    {
        InitializeSpawners();
        InitializePool();
    }

    private void InitializeSpawners()
    {
        var spawnersCount = transform.childCount;
        _spawnPoints = new Transform[spawnersCount];
        for (int i = 0; i < spawnersCount; i++)
        {
            _spawnPoints[i] = transform.GetChild(i);
        }
    }

    private void Spawn()
    {
        if(_elapsedTime >= _spawnTime && TryGetObject(out GameObject enemy))
        {
            _elapsedTime = 0;
            var choosedSpawnPoint = Random.Range(0, _spawnPoints.Length);

            SetEnemy(enemy, _spawnPoints[choosedSpawnPoint].position);
        }
    }

    private void SetEnemy(GameObject enemy, Vector3 targetPosition)
    {
        enemy.SetActive(true);
        enemy.transform.position = targetPosition;
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        Spawn();
    }
}
