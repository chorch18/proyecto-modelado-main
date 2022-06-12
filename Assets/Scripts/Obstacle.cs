using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Obstacle : MonoBehaviour
{
    public GameObject myObject;
    int counter = 1;
    PlayerMovement playerMovement;

    private void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            // al chocar con un obstaculo el jugador muere
            playerMovement.Die();
            
            while (counter == 1)
            {
            Instantiate(myObject);
                counter++;
            }
        }
        
            
        
    }

    private void Update()
    {

    }
}