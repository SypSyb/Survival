using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    public GameObject invPanel;

    public ItemDisplay[] itemDisplay;
    public Item[] items;

    bool buttonClicked;
    int invSlot;

    // Use this for initialization
    void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (invPanel.activeSelf == true)
            {
                invPanel.SetActive(false);
            }
            else
            {
                invPanel.SetActive(true);
            }
        }

        InventoryChecker();
    }

    void InventoryChecker()
    {
        int i = 0;
        if (itemDisplay[i].item == null)
        {
            for (i= 0; i <= itemDisplay.Length - 1; i++)
            {
                itemDisplay[i].item = items[0];
            }
        }
    }
}
