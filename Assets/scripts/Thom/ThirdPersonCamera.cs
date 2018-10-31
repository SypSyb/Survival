using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

    [Header("Required")]
    public GameObject target;
    public GameObject rotatorXZ;
    public GameObject rotatorY;
    public GameObject playerBody;

    [Header("Settings")]
    public float speed;
    public float sensitivityXZ;
    public float sensitivityY;

    private void LateUpdate()
    {
        transform.LookAt(target.transform.position);
        float horizontal = Input.GetAxis("Mouse X") * sensitivityXZ;
        float upDown = Input.GetAxis("Mouse Y") * sensitivityY;
        upDown = -upDown;

        rotatorXZ.transform.Rotate(0, horizontal, 0);
        rotatorY.transform.Rotate(upDown, 0, 0);

        target.transform.position = Vector3.Lerp(playerBody.transform.position, transform.position, Time.deltaTime * speed);
    }
}
