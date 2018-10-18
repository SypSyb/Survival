using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [Header("Camera's")]
    public GameObject thirdPersonCam;
    public GameObject firstPersonCam;

    [Header("Third Person Camera Settings")]

    public Vector3 cameraOffset;
    public GameObject playerBody;


    [Header("Movement Settings")]
    public float movementSpeed = 10;
    public float turningSpeed = 60;

    private int cameraMode = 1;

    void Update()
    {
        Walk();
    }

    void Walk()
    {
        float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        playerBody.transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        playerBody.transform.Translate(0, 0, vertical);
    }
}
