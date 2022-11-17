using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltarAoJogo : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("inicial_menu");
        BgScript.BgInstance.Audio.clip = BgScript.BgInstance.mainMenuClip;
        
        if(!BgScript.BgInstance.isPaused) {
            BgScript.BgInstance.Audio.Play();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("gameover");
        BgScript.BgInstance.Audio.clip = BgScript.BgInstance.gameoverClip;
        
        if(!BgScript.BgInstance.isPaused) {
            BgScript.BgInstance.Audio.Play();
        }
    }

    public void Vitoria()
    {
        
        SceneManager.LoadScene("Vitoria");
        BgScript.BgInstance.Audio.clip = BgScript.BgInstance.victoryClip;
        
        if(!BgScript.BgInstance.isPaused) {
            BgScript.BgInstance.Audio.Play();
        }
    }
}
