using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	[SerializeField] private float movementSpeed;
	[SerializeField] private float rotationSpeed;

	// Use this for initialization
	void Start () 
	{
			
	}
	
	// Update is called once per frame
	void Update () 
	{
		float horizontal = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
		float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

		if(horizontal != 0)
		{
			transform.Rotate(new Vector3(0, horizontal, 0));
		} 

		if(vertical != 0)
		{
			transform.Translate(Vector3.forward * vertical);
		}
	}
}
