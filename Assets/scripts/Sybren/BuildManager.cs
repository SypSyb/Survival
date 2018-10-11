using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public BuildSystem buildSystem;
    public GameObject previewFoundation;
    public GameObject previewWall;
    public GameObject previewPillar;
    public GameObject previewCeleing;

    public int buildingSwitch;
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            buildSystem.NewBuild(previewFoundation);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buildSystem.NewBuild(previewWall);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buildSystem.NewBuild(previewCeleing);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            buildSystem.NewBuild(previewPillar);
        }






    }
}
