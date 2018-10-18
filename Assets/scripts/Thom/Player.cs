using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject thirdPersonCam;
    public GameObject firstPersonCam;

    public GameObject pivot;

    public GameObject camTarget;

    private int cameraMode = 1;

    public float movementSpeed = 10;
    public float turningSpeed = 60;

    void Update()
    {
        Walk();
    }

    void LateUpdate()
    {
        ThirdPersonCamera();
        FirstPersonCamera();
    }

    public void ThirdPersonCamera()
    {
        thirdPersonCam.transform.LookAt(camTarget.transform);

        float horizontal = Input.GetAxis("Mouse X");
        float upDown = Input.GetAxis("Mouse Y");

        pivot.transform.Rotate(0, horizontal, 0);
        pivot.transform.Rotate(upDown, 0, 0);

    }

    public void FirstPersonCamera()
    {

    }

    void Walk()
    {
        float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }
}
