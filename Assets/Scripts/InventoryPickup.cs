using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Generico oggetto che può essere raccolto solo se esiste un inventario
// e il giocatore può usare l'oggetto
public class InventoryPickup : MonoBehaviour
{
	// L'oggetto raccolto
	public GameObject equipmentPrefab;
		
	// Chi può raccogliere l'oggetto
	public CharacterType pickableBy;
	
	protected void OnTriggerEnter(Collider other)
	{
		// Controlla che sia il personaggio che è entrato nel trigger
		// if(!other.CompareTag("Player")) return;
		
		// Controlla che il personaggio abbia un inventario
		Inventory inv = other.GetComponent<Inventory>();
		if(inv == null) return;
		
		// Controlla che il personaggio possa raccogliere l'oggetto
		PlayerController pc = other.GetComponent<PlayerController>();
		if(pc == null || pc.type != pickableBy) return;
		
		// Aggiunge l'equipaggiamento all'inventario
		inv.AddEquipment(equipmentPrefab);
		
		// Distrugge questo pickup
		Destroy(gameObject);
	}
}
