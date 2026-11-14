using UnityEngine;

public class ControllerBall : MonoBehaviour
{
    [Range(1f, 10f)][SerializeField] private float speed = 1; // усиление скорости

    private Rigidbody body;  // сам RB
    private Vector3 movement; // переменная перемещения
    private void Start() => body = GetComponent<Rigidbody>(); //иницилизация RB 
    private void Update() => movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")); // Помещаем wasd в X и Z
    private void FixedUpdate() => body.AddForce(movement * speed * Time.fixedTime); // множим переменные, добавля временную переменную для более корректной работы

}
