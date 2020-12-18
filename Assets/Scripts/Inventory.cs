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
	
	public GameObject GetRandomEquipment()
	{
		int index = Random.Range(0, equipmentList.Count);
		
		GameObject prefab = equipmentList[index];
		
		equipmentList.Remove(prefab);
		
		return prefab;
	}
}
