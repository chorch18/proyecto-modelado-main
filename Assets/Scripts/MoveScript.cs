using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{
    //private float speed = 10f;
    
    private bool going_right = false;
    float speed;
    float x;
    float y = 0.5f;
    public float z = 10;
    Vector3 pos;
    void Start()
    {
        x = Random.Range(0, 5);
        speed = Random.Range(10, 15);
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }

    void Update()
    {
        

        if (going_right)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed); // Move right
            if (transform.position.x > 5) // Too far right
            {
                going_right = false; // Switch direction
            }
        }
        else
        {
            transform.Translate(-Vector3.right * Time.deltaTime * speed); // Move left
            if (transform.position.x < -5) // Too far left
            {
                going_right = true; // Switch direction
                
            }
        }
    }
}