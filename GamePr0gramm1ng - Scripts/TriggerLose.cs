using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerLose : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ControllerUI.instance.triggerLose = true;
        }

    }
}
