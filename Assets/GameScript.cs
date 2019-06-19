using System.Collections;
using JetBrains.Annotations;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Enemy;
    public Vector3 Position;

    public GameObject Cloud;
    public float Delay;
    private GameObject _spawnedEnemy;

    void Start()
    {
        SpawnEnemy();
        StartCoroutine(SpawnCloud());
    }

    public void SpawnEnemy()
    {
        _spawnedEnemy = Instantiate(Enemy[Random.Range(0, Enemy.Length)], Position, Quaternion.identity);
    }

    private IEnumerator SpawnCloud()
    {
        while (true)
        {
            Instantiate(Cloud, new Vector3(-3.65f, Random.Range(1f, 4f), 0f), Quaternion.identity);
            yield return new WaitForSeconds(Delay);
        }
    }

    [UsedImplicitly]
    public void DestroyEnemy()
    {
        Destroy(_spawnedEnemy);
        // SpawnEnemy();
    }

    public void Click()
    {
        if (Input.GetMouseButtonUp(0))
        {
            _spawnedEnemy.transform.localScale += new Vector3(0.1f, 0.1f, 0f);
            if (_spawnedEnemy.transform.localScale.x >= 1.5f)
            {
                DestroyEnemy();
                SpawnEnemy();
            }
            
        }
    }

    // Update is called once per frame
    private void Update()
    {
//        if (Input.GetMouseButtonDown(0))
//        {
//            //Enemy[0].transform.localScale += new Vector3(0.1f, 0.1f, 0f);
//        }
        Click();
    }
}