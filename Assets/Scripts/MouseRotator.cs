using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Componente che permette di ruotare un oggetto al muoversi del mouse
public class MouseRotator : MonoBehaviour
{

	// Velocità di rotazione
	public float rotationSpeed = 1.5f;
	
    void Update()
    {
	    Vector3 rot = Vector3.up * rotationSpeed * Input.GetAxis("Mouse X");
	    transform.Rotate(rot);
    }
}
