using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float leftBound = -33;
    private float rightBound = 33;

    // Update is called once per frame
    void Update()
    {
        //If an object goes past the players view in the game, remove that object
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }else if(transform.position.z < lowerBound) 
        {
            Destroy(gameObject); 
        }
        else if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }

    }
}
