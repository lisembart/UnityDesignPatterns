using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight_Melee : IFightTactic 
{
    public void Attack()
    {
        Debug.Log("I attack with the sword.");
    }
}
