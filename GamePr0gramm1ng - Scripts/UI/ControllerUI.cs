using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class ControllerUI : MonoBehaviour
{
    public static ControllerUI instance;

    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private TextMeshProUGUI win;
    [SerializeField] private TextMeshProUGUI time;
    [SerializeField] private TextMeshProUGUI stars;

    private int count = 0;
    private float timeCount;
    private float check = 5;
    public bool triggerLose = false;

    private void Start()
    {
        instance = this;

    }

    private void Update()
    {
        score.text = "Score: " + count;
        timeCount += Time.deltaTime;
        time.text = "Time: " + Convert.ToInt32(timeCount);
        if (count >= 5)
        {
            check -= Time.deltaTime;
            win.text = "Victory! " + Convert.ToInt32(check);
            stars.text = CheckStars();
            if (check < 0)
                LoadLvl();
        }
        else if (triggerLose)
        {
            check -= Time.deltaTime;
            win.text = "You lose! " + Convert.ToInt32(check);
            if (check < 0)
                LoadLvl();
        }
            
    }
    public void AddCount() => count++;

    private void LoadLvl()
    {
        int numScene = SceneManager.GetActiveScene().buildIndex;

        if (!triggerLose && numScene != 4)
        {
            GlobalData.SharedInstance.data = numScene + 1;
            GlobalData.SharedInstance.maxLvl++;
        }
        else
            GlobalData.SharedInstance.data = numScene;


        SceneManager.LoadScene(1);

    }

    private string CheckStars()
    {
        if (timeCount < 10) return "* * *";
        else if (timeCount < 20) return "* *";
        else return " * ";

    }
}
