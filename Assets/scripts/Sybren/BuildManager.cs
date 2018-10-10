using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public BuildSystem buildSystem;
    public GameObject previewFoundation;
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.B))
        {
            buildSystem.NewBuild(previewFoundation);
        }

	}
}
