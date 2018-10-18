using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

    [Header("Required")]
    public GameObject target;
    public GameObject playerBody;

    [Header("Settings")]
    public float speed;

    private void LateUpdate()
    {
        transform.LookAt(target.transform.position);
        float horizontal = Input.GetAxis("Mouse X");
        float upDown = Input.GetAxis("Mouse Y");

        target.transform.Rotate(0, horizontal, 0);
        target.transform.Rotate(upDown, 0, 0);

        target.transform.position = Vector3.Lerp(playerBody.transform.position, transform.position, Time.deltaTime * speed);
    }
}
