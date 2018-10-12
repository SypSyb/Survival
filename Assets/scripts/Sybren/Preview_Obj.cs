using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preview_Obj : MonoBehaviour {

    public GameObject realThing;

    private MeshRenderer myRend;
    public Material canMat;
    public Material cantMat;


    public bool isSnapped = false;
    public bool isFoundation = false;


    private void Start()
    {
        myRend = GetComponent<MeshRenderer>();
        ChangeColor();
    }

    public void Place()
    {
        GameObject go = Instantiate(realThing, transform.position, transform.rotation);
        go.GetComponent<Actual_Obj>().TurnOnSnaps();
        Destroy(gameObject);
    }


    public void ToggleSnaps(bool value)
    {
        isSnapped = value;
        ChangeColor();
    }


    private void ChangeColor()
    {
        if (isSnapped)
        {
            myRend.material = canMat;
        }
        else
        {
            myRend.material = cantMat;
        }

        if (isFoundation)
        {
            isSnapped = true;
            myRend.material = canMat;
        }



    }
}
