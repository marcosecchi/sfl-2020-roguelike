using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPickup : MonoBehaviour
{
	public GameObject equipmentPrefab;
	
	protected void OnTriggerEnter(Collider other)
	{
		if(!other.CompareTag("Player")) return;
		Inventory inv = other.GetComponent<Inventory>();
		if(inv == null) return;
		//		inv.AddEquipment(equipmentPrefab);
		
		Destroy(gameObject);
	}
}
