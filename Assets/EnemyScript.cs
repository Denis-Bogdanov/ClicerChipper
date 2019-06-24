using System;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Action _callback;
    private GameScript _gameScript;

    public int Score;

    public void SetData(GameScript gameScript, Action callback)
    {
        _gameScript = gameScript;
        _callback = callback;
    }

    public void DestroyEnemy()
    {
        Destroy(gameObject);
    }


    public void OnMouseDown()
    {
        gameObject.transform.localScale += new Vector3(0.1f, 0.1f, 0f);
        if (gameObject.transform.localScale.x >= 1.5f)
        {
            DestroyEnemy();
            _gameScript.Score += Score;
            _gameScript.SetScore();
            if (_callback != null)
            {
                _callback();
            }
        }
    }
}