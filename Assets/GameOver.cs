using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text score;

    void Start()
    {
        score.text = string.Format("Score {0}", GameScript.AllScore);
    }

    public void PlayPressed()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitPress()
    {
        Application.Quit();
    }
}