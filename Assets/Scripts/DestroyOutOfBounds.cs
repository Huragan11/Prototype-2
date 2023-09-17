using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float leftBound = -33;
    private float rightBound = 33;
    private DetectCollisions detectCollisions;
    // Update is called once per frame
    private void Start()
    {
        detectCollisions = new DetectCollisions();
    }
    void Update()
    {

        //If an object goes past the players view in the game, remove that object
        if (transform.position.z > topBound)
        {
            detectCollisions.LoseLife();
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            detectCollisions.LoseLife();
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBound)
        {
            detectCollisions.LoseLife();
            Destroy(gameObject);
        }
        else if (transform.position.x < leftBound)
        {
            detectCollisions.LoseLife();
            Destroy(gameObject);
        }

    }
}
