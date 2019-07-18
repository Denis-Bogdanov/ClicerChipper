using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    public GameObject[] Enemy;
    public Vector3 Position;
    public GameObject Cloud;
    public float Delay;
    private GameObject _spawnedEnemy;

    public Text ScoreText;
    public int Score;
    public static int AllScore; // нужна для вывода очков в новую сцену


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

    private IEnumerator SpawnCloud()    // спавн облачка на разных высотах с разной скоростью
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