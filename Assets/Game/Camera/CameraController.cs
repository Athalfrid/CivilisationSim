using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float moveSpeed = 20f;

    [Header("Zoom")]
    [SerializeField] private float zoomSpeed = 5f;
    [SerializeField] private float minZoom = 4f;
    [SerializeField] private float maxZoom = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Camera camera;
    private void Awake()
    {
        camera = GetComponent<Camera>();

    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        HandleZoom();
    }

    private void HandleMovement()
    {

    }

    private void HandleZoom()
    {
        float scroll = Mouse.current.scroll.ReadValue().y;

        camera.orthographicSize -= scroll * zoomSpeed * Time.deltaTime;
        camera.orthographicSize = Mathf.Clamp(
            camera.orthographicSize - camera.orthographicSize, minZoom, maxZoom
        );
    }
}
