using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loockcamera : MonoBehaviour {

    [SerializeField] private string mouseXInputName, mouseYInputName; //poner el nombre del imput del ratón
    [SerializeField] private float mouseSensitivity; //definir la sensibilidad

    [SerializeField] private Transform playerBody;

    private float xAxisClamp; //para que no pase la camara por debajo o arriba y parezca que este dando una voltereta el personaje 

    private void Awake()
    {
        
        LockCursor(); //bloquear cursor en el centro de la pantalla
        xAxisClamp = 0.0f;
    }


    //bloquear cursor en el centro de la pantalla

    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    //desbloquear el cursor

    private void DontLockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    private void Update()
    {
        CameraRotation();
        if (Input.GetKey(KeyCode.Tab) || Input.GetKey(KeyCode.E))
        {
            DontLockCursor();
        }
        else
        {
            LockCursor();
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            Camera.main.fieldOfView = 15;
        }
        else
        {
            Camera.main.fieldOfView = 60;
        }

    }
    

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis(mouseXInputName) * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis(mouseYInputName) * mouseSensitivity * Time.deltaTime;

        xAxisClamp += mouseY; //solo funciona en el axisY

        if (xAxisClamp > 90.0f)
        {
            xAxisClamp = 90.0f;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(270.0f);
        }
        else if (xAxisClamp < -90.0f)
        {
            xAxisClamp = -90.0f;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(90.0f);
        }

        transform.Rotate(Vector3.left * mouseY);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    private void ClampXAxisRotationToValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        eulerRotation.y = value;
        transform.eulerAngles = eulerRotation;
    }
}
