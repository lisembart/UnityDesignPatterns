using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, IScoreObserver 
{
    public void UpdateScore(int currentScore, int bestScore)
    {
        if(currentScore > bestScore)
		{
			Debug.Log("New best score");
		}

		if(currentScore > 50)
		{
			Debug.Log("End game");
		}
    }
}
