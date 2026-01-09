using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    float speed = 1;

    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed;

        Vector3 currentMousePosition = Mouse.current.position.ReadValue();

        Vector3 camPos = gameCamera.ScreenToWorldPoint(currentMousePosition);
    }
}
