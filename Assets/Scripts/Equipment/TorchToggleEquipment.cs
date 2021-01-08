using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Esempio di torcia che effettua un FlipFlop ogni volta che si attiva
public class TorchToggleEquipment : TorchEquipment
{
	void Start()
	{
		torch.enabled = false;
	}
	
	public override void Activate()
	{
		torch.enabled = !torch.enabled;
	}
	
	public override void Deactivate()
	{
	}
}
