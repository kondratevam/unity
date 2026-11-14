using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    public void ShowMenu (GameObject menu)
    {
        menu.SetActive (true);
        Time.timeScale = 0f;
    }

    public void Resume(GameObject menu)
    {
        menu.SetActive (false);
        Time.timeScale = 1f;
    }
    public void MainMenu ()
    {
        Time.timeScale = 1f;
        GlobalData.SharedInstance.data = 0;
        SceneManager.LoadScene(1);
        
    }
    public void Exit ()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }
}
