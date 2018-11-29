using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour, IScoreObserver 
{
	public Text scoreText;

	private void Start() 
	{
		scoreText.text = "Score: 0";
		ScoreManager.AddObserver(this);
	}

    public void UpdateScore(int currentScore, int bestScore)
    {
        scoreText.text = "Score: " + currentScore.ToString();
    }

}
