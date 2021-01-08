using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEquipment : MonoBehaviour
{
	// Durata di attivazione dell'equipaggiamento
	public float activationTime = 10;
	
	// Indica (internamente) se l'oggetto è attivo oppure no
	private bool _active;
	
	// Funzione preposta all'attivazione dell'equipaggiamento
	public virtual void Activate()
	{
		// Se l'oggetto è già attivo, non faccio niente
		if(_active) return;
		
		_active = true;

		Debug.Log("Equipaggiamento attivato: " + name);
		
		// Se il tempo di attivazione è minore o uguale a zero,
		// l'attivazione deve durare indefinitamente
		if(activationTime <= 0) return;
		
		// Esegue la disattivazione dopo un determinato periodo di tempo
		Invoke("Deactivate", activationTime);
	}

	// Funzione preposta alla disattivazione dell'equipaggiamento
	public virtual void Deactivate()
	{
		_active = false;
		Debug.Log("Equipaggiamento disattivato: " + name);
	}
}
