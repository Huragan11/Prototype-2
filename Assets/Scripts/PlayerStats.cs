using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private int Lives;
    private int Score;

    private void Start()
    {
        Score = 0;
        Lives = 3;
    }

    public void AddScore()
    {
        Score++;
        Debug.Log("Score = " + Score);
    }
    public void RemoveLife()
    {
        Lives--;
        Debug.Log("Lives = " + Lives);
        if (Lives == 0)
        {
            Debug.Log("GameOver");
        }
    }
}
