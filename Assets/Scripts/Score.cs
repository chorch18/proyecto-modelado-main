using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    

    void Update()
    {
        if (player.position.z >= 0)
        {
            if (player.position.z <= 100)
            {
                scoreText.text = "score: " + player.position.z.ToString("0");
            }
            else
            {
                scoreText.text = ("win");
            }
        }
        else
        {
            scoreText.text = "starting...";
        }
    }
     
            
        
    
}
