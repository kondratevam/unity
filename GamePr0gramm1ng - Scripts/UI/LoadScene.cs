using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private Slider progressBar;
    [SerializeField] private GameObject textLoad;

    private AsyncOperation operation;


    private void Start()
    {
        operation = SceneManager.LoadSceneAsync(GlobalData.SharedInstance.data);
        operation.allowSceneActivation = false;
    }

    private void Update()
    {
        progressBar.value = (float)operation.progress;
        if (operation.progress == 0.9f && !operation.allowSceneActivation)
        {
            textLoad.SetActive(true);
            progressBar.value = 1.0f;
            if (Input.anyKeyDown)
                operation.allowSceneActivation = true;

        }
    }

}
