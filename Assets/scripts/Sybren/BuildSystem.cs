using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSystem : MonoBehaviour {

    public Camera cam;
    public LayerMask layer;
    private GameObject buildThing;

    public float stickToletance = 1.5f;

    public bool isBuilding = false;
    private bool pauseBuilding = false;

    private void Update()
    {
        //rotate
        if(Input.GetKeyDown(KeyCode.R))
        {
            buildThing.transform.Rotate(0, 90f, 0);
        }
        //stop
        if(Input.GetMouseButtonDown(0))
        {
            StopBuild();
        }
        //isbld
        if(isBuilding)
        {
            DoBuildRay();
        }
    }

    public void NewBuild(GameObject _obj)
    {
        Vector3 pos = transform.position + (Vector3.forward * 7f);
        GameObject go = Instantiate(_obj, pos, Quaternion.identity);
        buildThing = go;
        isBuilding = true;
    }

    private void pauseBuild()
    {

    }

    private void StopBuild()
    {
        //buildThing.GetComponent<Preview_Obj>().Place();
        buildThing = null;
        isBuilding = false;

    }

    private void DoBuildRay()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, 15f, layer))
        {
            buildThing.transform.position = hit.point;
        }
    }
}
