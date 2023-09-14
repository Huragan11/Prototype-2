using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves object forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
