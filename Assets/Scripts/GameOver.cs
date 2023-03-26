using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject painelGameOver;
    
   

    public void Menu()
    {
        SceneManager.LoadScene("inicial_menu");
        BgScript.BgInstance.Audio.clip = BgScript.BgInstance.mainMenuClip;
        
        if(!BgScript.BgInstance.isPaused) {
            BgScript.BgInstance.Audio.Play();
        }
       
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("CenaInventario");
       
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
