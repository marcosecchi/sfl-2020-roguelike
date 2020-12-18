using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPickup : MonoBehaviour
{
	public GameObject equipmentPrefab;
	
	public CharacterType pickableBy;
	
	protected void OnTriggerEnter(Collider other)
	{
		if(!other.CompareTag("Player")) return;
		Inventory inv = other.GetComponent<Inventory>();
		if(inv == null) return;
		PlayerController pc = other.GetComponent<PlayerController>();
		if(pc == null || pc.type != pickableBy) return;
		
		inv.AddEquipment(equipmentPrefab);
		
		Destroy(gameObject);
	}
}
