using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
    private static int lives = 3;
    private static int score = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Projectile"))
        {
            if (!other.gameObject.CompareTag("Player"))
            {
                Destroy(gameObject);
                other.gameObject.GetComponentInChildren<Slider>().value += 1;
                if (other.gameObject.GetComponentInChildren<Slider>().value == other.gameObject.GetComponentInChildren<Slider>().maxValue)
                {
                    Destroy(other.gameObject);
                    score++;
                    Debug.Log("Score: " + score);
                }
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

    public void LoseLife()
    {
        lives--;
        Debug.Log("Lives: " + lives);
        if (lives == 0)
        {
            Debug.Log("Game Over!!");
        }
    }


}
