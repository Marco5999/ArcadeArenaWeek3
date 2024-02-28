using UnityEngine;

public class FPSController : MonoBehaviour
{
    public Camera fpsCamera;
    [SerializeField] float lookSpeed = 2.0f;
    [SerializeField] float lookLimitX = 45f;
    float rotationX = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
        rotationX = Mathf.Clamp(rotationX, -lookLimitX, lookLimitX);
        fpsCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
    }
}
