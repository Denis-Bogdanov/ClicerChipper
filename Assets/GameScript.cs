using System;
using JetBrains.Annotations;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Enemy;
    public Vector3 Position;

    private GameObject _spawnedEnemy;

    void Start()
    {
        SpawnEnemy();
    }

    public void SpawnEnemy()
    {
        _spawnedEnemy = Instantiate(Enemy[Random.Range(0, Enemy.Length)], Position, Quaternion.identity);
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            DestroyEnemy();
        }
    }

    [UsedImplicitly]
    public void DestroyEnemy()
    {
        Destroy(_spawnedEnemy);
        SpawnEnemy();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}