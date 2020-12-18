using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
	public Transform slot1;
	public Transform slot2;
	
	public GameObject startingWeapon1Prefab;
	public GameObject startingWeapon2Prefab;
	
	public Inventory inventory;
	
	private GameObject _equippedWeapon1Prefab;
	private GameObject _equippedWeapon2Prefab;
	
    void Start()
	{
	    EquipWeapon1(startingWeapon1Prefab);
	    EquipWeapon2(startingWeapon2Prefab);
    }

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
	}
	
	
}
