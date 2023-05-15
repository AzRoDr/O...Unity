using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _score;

    public void GameOver()
    {
        Debug.Log("Game Over");
    }

    
    public void IncreaseScore()
    {
        _score++;
    }
}
