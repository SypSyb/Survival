using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snappoint : MonoBehaviour {

    SphereCollider myCollider;
    BuildSystem buildSystem;


    private bool canSnap = false;
    public string TagImLookingFor;

    private void Start()
    {
        buildSystem = GameObject.FindObjectOfType<BuildSystem>();
        myCollider = GetComponent<SphereCollider>();
    }

    public void TurnOnSnaps()
    {
        canSnap = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(canSnap)
        {
            if(other.tag == TagImLookingFor)
            {
                other.transform.position = transform.position;
                if (other.tag == "Pillar")
                {
                    other.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else
                {
                    other.transform.rotation = Quaternion.Euler(-90, 0, 0);
                }

                other.GetComponent<Preview_Obj>().ToggleSnaps(true);

                canSnap = false;
                buildSystem.PauseBuild(true);


                
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        canSnap = true;
        other.GetComponent<Preview_Obj>().ToggleSnaps(false);
    }


}
