using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speedMovement = 5f; // Скорость ходьбы

    private Vector3 movementVector;
    private void Update()
    {
        movementVector = (transform.right * Input.GetAxis("Horizontal")) + (transform.forward * Input.GetAxis("Vertical")); // вычисляем нажатием wasd в векторе. 

    }
    private void FixedUpdate()
    {
        transform.position += movementVector * speedMovement * Time.fixedDeltaTime; // Перемещение
    }
}
