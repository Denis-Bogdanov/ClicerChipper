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
        
    }

    [UsedImplicitly]
    public void DestroyEnemy()
    {
        Destroy(_spawnedEnemy);
       // SpawnEnemy();
    }

    public void Click()
    {
        if (Input.GetMouseButton(0))
        {
            //Enemy[0].transform.localScale += new Vector3(0.1f, 0.1f, 0f);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Enemy[0].transform.localScale += new Vector3(0.1f, 0.1f, 0f);
        }
    }
}