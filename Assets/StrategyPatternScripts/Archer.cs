using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Character
{
	void Start () 
	{
		fightTactic = new Fight_Shooting();
		Fight();
	}
}
