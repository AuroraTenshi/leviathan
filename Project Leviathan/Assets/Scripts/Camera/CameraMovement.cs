using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 cameraPosition;
    [Header("Camera Settings")]
    public float cameraSpeed;

    private void Start()
    {
        cameraPosition = this.transform.position;
    }

    private void Update()
    {
        float edgePixels = 10f;

        if (Input.GetKey(KeyCode.W) || Input.mousePosition.y > Screen.height - edgePixels)
        {
            cameraPosition.z += cameraSpeed / 100;
        }
        if (Input.GetKey(KeyCode.S) || Input.mousePosition.y < edgePixels)
        {
            cameraPosition.z -= cameraSpeed / 100;
        }
        if (Input.GetKey(KeyCode.D) || Input.mousePosition.x > Screen.width - edgePixels)
        {
            cameraPosition.x += cameraSpeed / 100;
        }
        if (Input.GetKey(KeyCode.A) || Input.mousePosition.x < edgePixels)
        {
            cameraPosition.x -= cameraSpeed / 100;
        }

        this.transform.position = cameraPosition;
    }

    public void Reset()
    {
        cameraPosition.x = 0;
        cameraPosition.z = 0;
        this.transform.position = cameraPosition;
    }
}
