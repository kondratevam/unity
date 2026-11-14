using UnityEngine;

public class ControllerTarget : MonoBehaviour
{
    private GameObject target;

    private void Start() => target = this.gameObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
            Death();
    }

    private void Death()
    {
        Destroy(target);
        ControllerUI.instance.AddCount(); 
    }
}
