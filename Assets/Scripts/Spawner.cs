using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform _target;
    [SerializeField] private List<Transform> _spawnPosition;
    [SerializeField] private float _spawnDelay;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var wait = new WaitForSeconds(_spawnDelay);

        while (true)
        {
            yield return wait;
            CreatEnemy();
        }
    }

    private void CreatEnemy()
    {
        var spawnPosition = UserUtils.GetRandomValueFromList(_spawnPosition);
        var enemy = Instantiate(_enemyPrefab, spawnPosition.position, Quaternion.identity);
        enemy.Init(_target);
    }
}