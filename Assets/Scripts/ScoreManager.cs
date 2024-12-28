using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    static public ScoreManager Instance {get; private set;} 
    private int scoreAmount;

    private void Awake() {
        Instance = this;
    }
    public void AddScore(int amount)
    {
        scoreAmount += amount;
        Debug.Log(scoreAmount);
    }

}
