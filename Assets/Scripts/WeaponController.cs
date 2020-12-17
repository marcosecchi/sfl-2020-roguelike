using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
	public Transform slot1;
	public Transform slot2;
	
	public GameObject startingWeapon1Prefab;
	public GameObject startingWeapon2Prefab;
	
    void Start()
    {
	    EquipWeapon1(startingWeapon1Prefab);
	    EquipWeapon2(startingWeapon2Prefab);
    }

	public void EquipWeapon1(GameObject prefab)
	{
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
		foreach(Transform child in slot2)
		{
			Destroy(child.gameObject);
		}
		if(prefab != null)
		{
			Instantiate(prefab, slot2.position, slot2.rotation, slot2);
		}
	}
	
	
	
	
}
