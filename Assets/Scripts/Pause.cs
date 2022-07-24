using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PainelPause, ButtonPause;
    public static bool game_paused = false;
   
    public void PauseGame()
    {

        PainelPause.SetActive(true);
        ButtonPause.SetActive(false);
        Time.timeScale = 0f;
        game_paused = true;
    }

    public void ResumeGame()
    {
        PainelPause.SetActive(false);
        ButtonPause.SetActive(true);
        Time.timeScale = 1f;
        game_paused = false;
    }



    
}
