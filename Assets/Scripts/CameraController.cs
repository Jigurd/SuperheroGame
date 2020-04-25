using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 13.5f;
    [SerializeField] private float _zoomSpeed = 2.0f;
    [SerializeField] private float _minimumOrthographicSize = 3.0f;
    [SerializeField] private float _maximumOrthographicSize = 25.0f;

    //[SerializeField] private bool edgeScrolling = false;

    private Camera mainCamera;

    Vector2 previousMousePosition = Vector2.zero;

    void Awake()
    {
        mainCamera = GetComponent<Camera>();
        previousMousePosition = Input.mousePosition;
    }

    void Update()
    {
        // Keyboard controlled movement
        Vector2 direction = Vector2.zero;


        // Up
        if (Input.GetKey(KeyCode.W))
        {
            direction.y = 1.0f;
        }
        //Down
        if (Input.GetKey(KeyCode.S))
        {
            direction.y = -1.0f;
        }
        // Right
        if (Input.GetKey(KeyCode.D))
        {
            direction.x = 1.0f;
        }
        // Left
        if (Input.GetKey(KeyCode.A))
        {
            direction.x = -1.0f;
        }

        transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);



        // middle click panning
        Vector2 mousePosition =
            mainCamera.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButton(2))
        {
            Vector2 mouseDelta = mousePosition - previousMousePosition;
            transform.Translate(-mouseDelta);
        }
        previousMousePosition =
            mainCamera.ScreenToWorldPoint(Input.mousePosition);

        // zooming
        float zoomDelta = -Input.GetAxisRaw("Mouse ScrollWheel") * _zoomSpeed;
        zoomDelta *= mainCamera.orthographicSize - _minimumOrthographicSize + 1;
        mainCamera.orthographicSize += zoomDelta;
        mainCamera.orthographicSize = Mathf.Clamp(
            mainCamera.orthographicSize,
            _minimumOrthographicSize,
            _maximumOrthographicSize
        );
    }
}
