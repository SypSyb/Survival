using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSystem : MonoBehaviour {

    public Camera cam;
    public LayerMask layer;
    private GameObject buildThing;

    public float stickTolerance = .05f;

    public bool isBuilding = false;
    private bool pauseBuilding = false;

    private void Update()
    {
        //rotate
        if(Input.GetKeyDown(KeyCode.R))
        {
            buildThing.transform.Rotate(0, 0, 90);
        }
        //stop
        if(Input.GetMouseButtonDown(0))
        {
            if(buildThing.GetComponent<Preview_Obj>().isSnapped)
            {
                StopBuild();
            }

                
            
        }
        //isbld

        if (isBuilding)
        {
            if (pauseBuilding)
            { 
                float mouseX = Input.GetAxis("Mouse X");
                float mouseZ = Input.GetAxis("Mouse Y");

                if (Mathf.Abs(mouseX) >= stickTolerance || Mathf.Abs(mouseZ) >= stickTolerance)
                {
                    pauseBuilding = false;
                }
            }
            else
            {
                DoBuildRay();
            }
        }
    }

    public void NewBuild(GameObject _obj)
    {
        Vector3 pos = transform.position + (Vector3.forward * 7f);
        GameObject go = Instantiate(_obj, pos, Quaternion.Euler(-90, 0, 0));
        buildThing = go;
        isBuilding = true;
    }

    public void PauseBuild(bool value)
    {
        pauseBuilding = value;
    }

    private void StopBuild()
    {
        buildThing.GetComponent<Preview_Obj>().Place();
        buildThing = null;
        isBuilding = false;

    }

    private void DoBuildRay()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, 10f, layer))
        {
            buildThing.transform.position = hit.point;
        }
    }
}
