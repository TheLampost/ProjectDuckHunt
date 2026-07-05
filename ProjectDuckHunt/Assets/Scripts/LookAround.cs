using UnityEngine;
using UnityEngine.InputSystem;

public class LookAround : MonoBehaviour
{
    float sensitivity = 0.1f;
    float xRotation = 0f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector2 mouseDelta = Mouse.current.delta.ReadValue();

        float mouseX = mouseDelta.x * sensitivity;
        float mouseY = mouseDelta.y * sensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);


        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.parent.Rotate(Vector3.up * mouseX);
    }
}

