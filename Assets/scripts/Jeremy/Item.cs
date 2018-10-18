using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    NONE,
    FOOD,
    TOOL,
    MATERIAL
}

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item : ScriptableObject
{
    [Header("Variables for scripting")]
    public ItemType itemType;
    public int amount;

    [Header("Variables for the UI")]
    public new string name;
    public string desc;
    public Sprite image;
    public int itemAmount;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
