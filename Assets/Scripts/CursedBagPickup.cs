using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursedBagPickup : MonoBehaviour
{
	protected void OnTriggerEnter(Collider other)
	{
		// Controlla che sia il personaggio che è entrato nel trigger
		if(!other.CompareTag("Player")) return;
		
		// Controlla che il personaggio abbia un inventario
		Inventory inv = other.GetComponent<Inventory>();
		if(inv == null) return;
		
		inv.Curse();
		
		// Distrugge questo pickup
		Destroy(gameObject);
	}
}
