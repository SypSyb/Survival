using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preview_Obj : MonoBehaviour {

    public GameObject realThing;

    public void Place()
    {
        GameObject go = Instantiate(realThing, transform.position, transform.rotation);
        go.GetComponent<Actual_Obj>().TurnOnSnaps();
        Destroy(gameObject);
    }
}
