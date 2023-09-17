using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private static int lives = 3;
    private static int score = 0;
   // public GameObject PlayerStats;
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Projectile"))
        {
            if (!other.gameObject.CompareTag("Player"))
            {
                score++;
                Destroy(gameObject);
                Destroy(other.gameObject);
                Debug.Log("Score: " + score);
            }
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            lives--;
            Destroy(gameObject);
            Debug.Log("Lives: " + lives);
            if (lives == 0)
            {
                Destroy(other.gameObject);
                Debug.Log("Game Over!!");
            }
        }
    }
}
