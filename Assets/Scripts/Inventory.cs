using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Classe che gestisce il sistema di inventario
public class Inventory : MonoBehaviour
{
	
	// Lista degli oggetti in inventario
	private List<GameObject> equipmentList;
	
	// Quando l'inventario viene creato, inizializza la lista degli oggetti (vuota)
    void Start()
    {
	    equipmentList = new List<GameObject>();
    }
    
	// Permette di aggiungere un elemento alla lista dell'inventario
	public void AddEquipment(GameObject equipment)
	{
		equipmentList.Add(equipment);
	}
	
	// Ritorna un oggetto a caso dalla lista (rimuovendolo dalla stessa)
	public GameObject GetRandomEquipment()
	{
		int index = Random.Range(0, equipmentList.Count);
		
		GameObject prefab = equipmentList[index];
		
		equipmentList.Remove(prefab);
		
		return prefab;
	}
}
