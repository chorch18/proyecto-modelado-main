using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSoundPlay : MonoBehaviour
{
    public GameObject myPrefab;
    public GameObject Music;
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
            Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

   
}
