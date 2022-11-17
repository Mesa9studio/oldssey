using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vitoria : MonoBehaviour
{
    public GameObject painelWin;
    void Start()
    {
        StartCoroutine(GameWin());
    }

    IEnumerator GameWin()
    {
        yield return new WaitForSeconds(3);        
        painelWin.SetActive(true);
        
    }

    
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
        BgScript.BgInstance.Audio.clip = BgScript.BgInstance.gameplayClip;
        
        if(!BgScript.BgInstance.isPaused) {
            BgScript.BgInstance.Audio.Play();
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
