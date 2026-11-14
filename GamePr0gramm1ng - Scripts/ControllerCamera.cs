using UnityEngine;

public class ControllerCamera : MonoBehaviour
{
    [SerializeField] private GameObject gameObject;

    private Vector3 offset;

    void Start() => offset = transform.position - gameObject.transform.position;
    void LateUpdate() => transform.position = gameObject.transform.position + offset;

}
