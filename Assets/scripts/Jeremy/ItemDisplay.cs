using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    public Item item;
    public Text itemName;
    public Text itemDesc;
    public Image itemImage;
    public Text itemAmount;
    public GameObject descPanel;

	// Use this for initialization
	void Start ()
    {
        if(descPanel == isActiveAndEnabled)
        {
            descPanel.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(item != null)
        {
            itemName.text = item.name;
            itemDesc.text = item.desc;
            itemImage.sprite = item.image;
            itemAmount.text = item.itemAmount.ToString();
        }
    }

    public void DisplayDescription()
    {
        if (descPanel.activeSelf == true)
        {
            descPanel.SetActive(false);
        }
        else
        {
            descPanel.SetActive(true);
        }
    }
}
