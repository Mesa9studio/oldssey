using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(StartIntro());
    }

   IEnumerator StartIntro()
    {
        yield return new WaitForSeconds(26);
        SceneManager.LoadScene("CenaInventario");

        BgScript.BgInstance.Audio.clip = BgScript.BgInstance.gameplayClip;
        
        if(!BgScript.BgInstance.isPaused) {
            BgScript.BgInstance.Audio.Play();
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("CenaInventario");
        BgScript.BgInstance.Audio.clip = BgScript.BgInstance.gameplayClip;
        
        if(!BgScript.BgInstance.isPaused) {
            BgScript.BgInstance.Audio.Play();
        }
    }
}
