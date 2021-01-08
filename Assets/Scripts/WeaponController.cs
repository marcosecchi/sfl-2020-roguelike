using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Componente che permette di gestire le armi in possesso di un personaggio
public class WeaponController : MonoBehaviour
{
	// I punti dove agganciare le armi
	public Transform slot1;
	public Transform slot2;
	
	// I prefab delle armi iniziali
	public GameObject startingWeapon1Prefab;
	public GameObject startingWeapon2Prefab;
	
	// Riferimento all'inventario
	public Inventory inventory;
	
	// Due riferimenti ai prefab delle armi attualmente in uso
	private GameObject _equippedWeapon1Prefab;
	private GameObject _equippedWeapon2Prefab;
	
	// In fase di inizializzazione, equipaggia il personaggio con le armi predefinite
    void Start()
	{
	    EquipWeapon1(startingWeapon1Prefab);
	    EquipWeapon2(startingWeapon2Prefab);
	}
    
	// Equipaggia il primo slot con un'arma
	public void EquipWeapon1(GameObject prefab)
	{
		_equippedWeapon1Prefab = prefab;
		
		foreach(Transform child in slot1)
		{
			Destroy(child.gameObject);
		}
		if(prefab != null)
		{
			Instantiate(prefab, slot1.position, slot1.rotation, slot1);	
		}
	}

	// Equipaggia il secondo slot con un'arma
	public void EquipWeapon2(GameObject prefab)
	{
		_equippedWeapon2Prefab = prefab;
		
		foreach(Transform child in slot2)
		{
			Destroy(child.gameObject);
		}
		if(prefab != null)
		{
			Instantiate(prefab, slot2.position, slot2.rotation, slot2);
		}
	}
	
	// Controlla che il giocatore abbia premuto i pulsanti e, in caso positivo,
	// cambia l'arma con una nell'inventario
	void Update()
	{
		if(Input.GetButtonDown("Fire1"))
		{
			inventory.AddEquipment(_equippedWeapon1Prefab);
			GameObject eq1Prefab = inventory.GetRandomEquipment();
			EquipWeapon1(eq1Prefab);
		}
		if(Input.GetButtonDown("Fire2"))
		{
			inventory.AddEquipment(_equippedWeapon2Prefab);
			GameObject eq2Prefab = inventory.GetRandomEquipment();
			EquipWeapon2(eq2Prefab);			
		}
		
		if(Input.GetButtonDown("Jump"))
		{
			BaseEquipment[] ar = GetComponentsInChildren<BaseEquipment>();
			
			foreach(BaseEquipment item in ar)
			{
				item.Activate();
			}
			
		}

	}
	
	
}
