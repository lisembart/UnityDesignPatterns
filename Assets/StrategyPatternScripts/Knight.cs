using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Character
{	
	void Start () 
	{
		fightTactic = new Fight_Melee();
		Fight();
		fightTactic = new Fight_Shooting();
		Fight();
	}
}
