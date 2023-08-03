using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
/*     float currentTime = 0f;
    float startingTime= 120f;    
    public TextMeshProUGUI countdownText; */
    public GameObject GameOver, MissaoConcluida, Resgate;
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

         if (timeValue == 0)
        {
            GameOver.SetActive(true);
            Time.timeScale = 0f;
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

    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
        timeValue = 300;
    }
  /*    public void changeColor()
    {
        timerText.color = Color.RGBToHSV(255,137,51,255);
    }

    private Color Color32(int v1, int v2, int v3, int v4)
    {
        throw new NotImplementedException();
    } */
}
