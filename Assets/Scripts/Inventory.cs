using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
	
	private List<GameObject> equipmentList;
	
    void Start()
    {
	    equipmentList = new List<GameObject>();
    }
    
	public void AddEquipment(GameObject equipment)
	{
		equipmentList.Add(equipment);
	}
}
