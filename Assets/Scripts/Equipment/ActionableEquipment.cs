using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionableEquipment : BaseEquipment
{
	// Azioni da svolgere in fase di attivazione
	public UnityEvent activateAction;
	
	// Azioni da svolgere in fase di disattivazione
	public UnityEvent deactivateAction;
	
	public override void Activate()
	{
		base.Activate();
		activateAction.Invoke();
	}
	
	public override void Deactivate()
	{
		base.Deactivate();
		deactivateAction.Invoke();
	}
}
