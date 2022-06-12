using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineWIN : MonoBehaviour
{
    
    PlayerMovement playerMovement;

    private void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {

        }



    }

}