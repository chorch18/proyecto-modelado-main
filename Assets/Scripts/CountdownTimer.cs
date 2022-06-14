using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = -1.9f;

    [SerializeField] Text countdownText;



    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        countdownText.text = "time: " + currentTime.ToString("0");

        if(currentTime <= 0)
        {
            countdownText.text = "prepare...";
            
        }
    }
}
