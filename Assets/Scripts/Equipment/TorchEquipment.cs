using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Esempio di torcia attivabile e disattivabile
public class TorchEquipment : BaseEquipment
{
	// Riferimento al componente Light
	public Light torch;
	
    void Start()
	{
		Deactivate();
    }
    
	public override void Activate()
	{
		base.Activate();
		
		torch.enabled = true;
	}
	
	public override void Deactivate()
	{
		base.Deactivate();
		
		torch.enabled = false;
	}

}
