using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour 
{
	[Header("Character Stats")]
	protected string name;
	protected float health;
	protected float mana;
	protected float stamina;
	protected float strength;
	protected float dexterity;

	protected IFightTactic fightTactic;

	public void Fight()
	{
		fightTactic.Attack();
	}


	
}
