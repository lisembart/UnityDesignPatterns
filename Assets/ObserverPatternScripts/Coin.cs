using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	private void OnTriggerEnter(Collider other) 
	{
		if(other.gameObject.tag == "Player")
		{
			FindObjectOfType<ScoreManager>().AddPoint(5);
			Destroy(gameObject);
		}	
	}
}
