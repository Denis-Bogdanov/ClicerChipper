using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timer;
    void Start()
    {
        InvokeRepeating("RunTimer", 1, 1);
    }

    void RunTimer()
    {
        timer.text = (int.Parse(timer.text) - 1).ToString();
        if (int.Parse(timer.text) == 0)
        {
         CancelInvoke();
         SceneManager.LoadScene("EndGameScene");  
         
        }
    }

}
