using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight_Shooting : IFightTactic
{
    public void Attack()
    {
        Debug.Log("I attack with a bow.");
    }
}
