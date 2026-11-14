using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class CameraController : MonoBehaviour
{


    [Range(500f, 1500f)][SerializeField] private float xSens = 700f;
    [Range(500f, 1500f)][SerializeField] private float ySens = 700f;
    [SerializeField] private Rigidbody rb;

    private float rotateH;
    private float rotateV;

    private void Update()
    {

        rotateH += Input.GetAxis("Mouse X") * xSens * Time.deltaTime; // вычесляем движения мауза по X
        rotateV += Input.GetAxis("Mouse Y") * -ySens * Time.deltaTime; // вычесляем движения мауза по Y


        transform.rotation = Quaternion.Euler(rotateV, rotateH, 0f); //поворот камеры по X Y
        rb.transform.rotation = Quaternion.Euler(0f, rotateH, 0f); // поворот rb по Y
    }
}
