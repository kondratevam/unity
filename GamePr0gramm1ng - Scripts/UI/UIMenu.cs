using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject[] lvlPanels;
    public void MenuStart(int num)
    {
        num++;
        GlobalData.SharedInstance.data = num;
        SceneManager.LoadScene(1);
    }
    public void MenuExit()
    {
        Application.Quit();
    }

    public void ShowLvlPanel()
    {
        menu.SetActive(true);
        int length = GlobalData.SharedInstance.maxLvl - 1;
        for (int i = 0; i < length; i++) lvlPanels[i].SetActive(true);

    }

    public void HideLvlPanel()
    {
        menu.SetActive(false);
    }
}
