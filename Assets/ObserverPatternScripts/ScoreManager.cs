using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour 
{
	public int currentScore;
	public int bestScore;
	static List <IScoreObserver> scoreObservers = new List<IScoreObserver>();

	public static void AddObserver(IScoreObserver observer)
	{
		scoreObservers.Add(observer);
	}

	public static void RemoveObserver(IScoreObserver observer)
	{
		scoreObservers.Remove(observer);
	}

	public void NotifyObservers()
	{
		foreach(var observer in scoreObservers)
		{
			observer.UpdateScore(currentScore, bestScore);
			Debug.Log(observer, this);
		}
	}

	public void AddPoint(int value)
	{
		currentScore += value;
		NotifyObservers();
 	}
}
