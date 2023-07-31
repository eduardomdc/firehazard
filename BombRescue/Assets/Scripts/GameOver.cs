using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public float timeValue = 20;
    public GameObject gameOver;
    bool gameOverIs, restart;
    // Start is called before the first frame update

    // Update is called once per frame
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

        if (timeValue == 0)
        {
            gameOver.SetActive(true);
            gameOverIs = true;
        }
        if(gameOverIs == true)
        {
            Time.timeScale = 0;
        }
        if (gameOverIs == false)
        {
            Time.timeScale = 1;
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
        gameOverIs = false;
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
