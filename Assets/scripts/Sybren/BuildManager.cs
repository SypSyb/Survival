using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public BuildSystem buildSystem;
    public GameObject previewFoundation;
    public GameObject previewWall;

    public GameObject previewCeleing;

    public int buildingSwitch;
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.B) && buildSystem.isBuilding == false)
        {
            switch (buildingSwitch)
            {
                case 2:
                    buildSystem.NewBuild(previewCeleing);
                    break;

                case 1:
                    buildSystem.NewBuild(previewWall);
                    break;

                default:
                    buildSystem.NewBuild(previewFoundation);
                    break;

            }
        }
        if(buildSystem.isBuilding == true)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
            {
                buildingSwitch++;
            }
            else if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
            {
                buildingSwitch--;
            }

            if(buildingSwitch > 2)
            {
                buildingSwitch = 0;
            }
            if(buildingSwitch < 0)
            {
                buildingSwitch = 2;
            }
        }



	}
}
