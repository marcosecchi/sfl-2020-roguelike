using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
	// La classe del personaggio
	public CharacterType type;
	
	// Velocità di movimento
	public float speed = 3;
	
	// Velocità di rotazione
	public float rotationSpeed = 3;
	
	// Riferimento interno al CharacterController
	private CharacterController _controller;
	
    void Start()
	{
		// Cerca il CharacterController e lo assegna alla variabile corrispondente
	    _controller = GetComponent<CharacterController>();
    }

    void Update()
	{
		// Ruota il personaggio a seconda del movimento orizzontale del thumbstick
	    Vector3 rot = Vector3.up * rotationSpeed * Input.GetAxis("Horizontal");
	    transform.Rotate(rot);
	    
		// Muove il personaggio utilizzando il CharacterController
	    Vector3 mov = transform.forward * speed * Input.GetAxis("Vertical") * Time.deltaTime;
	    _controller.SimpleMove(mov);
    }
    
    
    
    
    
    
}
