using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfetiInstantiate : MonoBehaviour
{
    public GameObject Confeti1;
    public GameObject Confeti2;

    PlayerMovement playerMovement;
    private void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            // al chocar con un obstaculo el jugador muere
            Instantiate(Confeti1, new Vector3(5, 0, 110), Quaternion.identity);
            Instantiate(Confeti2, new Vector3(-5, 0, 110), Quaternion.identity);
        }
    }

}
