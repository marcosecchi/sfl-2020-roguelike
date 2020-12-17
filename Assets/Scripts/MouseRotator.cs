using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotator : MonoBehaviour
{

	public float rotationSpeed = 1.5f;
	
    void Update()
    {
	    Vector3 rot = Vector3.up * rotationSpeed * Input.GetAxis("Mouse X");
	    transform.Rotate(rot);
    }
}
