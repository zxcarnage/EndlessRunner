using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private int _capacity;
    [SerializeField] private Transform _container;
    [SerializeField] private GameObject _poolPrefab;

    private List<GameObject> _objectPool = new List<GameObject>();

    protected void InitializePool()
    {
        for (int i = 0; i < _capacity; i++)
        {
            var spawnedObject = Instantiate(_poolPrefab, _container);
            spawnedObject.SetActive(false);

            _objectPool.Add(spawnedObject);
        }
    }

    protected bool TryGetObject(out GameObject result)
    {
        result = _objectPool.FirstOrDefault(p => p.activeSelf == false);

        return result != null;
    }
}
