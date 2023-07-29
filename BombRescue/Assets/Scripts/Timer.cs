using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
/*     float currentTime = 0f;
    float startingTime= 120f;    
    public TextMeshProUGUI countdownText; */
    public float timeValue = 20;
    public TextMeshProUGUI timerText;
    void Update()
    {

        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;   
        }
        DisplayTime(timeValue);

        if (timeValue <= 10)
        {
            timerText.color = Color.red;
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay /60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
