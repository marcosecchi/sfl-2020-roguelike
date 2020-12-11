using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class KnightController : MonoBehaviour
{
	public float speed = 3;
	public float rotationSpeed = 3;
	
	private CharacterController _controller;
	
    // Start is called before the first frame update
    void Start()
    {
	    _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
	    Vector3 rot = Vector3.up * rotationSpeed * Input.GetAxis("Horizontal");
	    transform.Rotate(rot);
	    
	    Vector3 mov = transform.forward * speed * Input.GetAxis("Vertical") * Time.deltaTime;
	    _controller.SimpleMove(mov);
    }
    
    
    
    
    
    
}
