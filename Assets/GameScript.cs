using System.Collections;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Enemy;
    public Vector3 Position;
    public GameObject Cloud;
    public float Delay;
    private GameObject _spawnedEnemy;

    public Text ScoreText;
    public int Score;
    public static int AllScore = 0;
   
    

    void Start()
    {
        SpawnEnemy();
        StartCoroutine(SpawnCloud());
        
    }

    public void SpawnEnemy()
    {
        _spawnedEnemy = Instantiate(Enemy[Random.Range(0, Enemy.Length)], Position, Quaternion.identity);
        var enemy = _spawnedEnemy.GetComponent<EnemyScript>();
        if (enemy != null)
        {
            enemy.SetData(this, SpawnEnemy);
        }
    }

    private IEnumerator SpawnCloud()
    {
        while (true)
        {
            Instantiate(Cloud, new Vector3(-3.65f, Random.Range(1f, 4f), 0f), Quaternion.identity);
            yield return new WaitForSeconds(Delay);
        }
    }

    public void SetScore()
    {
        ScoreText.text = string.Format("Score {0}", Score);
        AllScore = Score;
    }
}