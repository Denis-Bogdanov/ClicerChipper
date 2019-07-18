using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}