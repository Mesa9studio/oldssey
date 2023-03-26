using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IrParaMenu : MonoBehaviour
{
    // Start is called before the first frame update
   public void Menu()
    {
        SceneManager.LoadScene("inicial_menu");
        BgScript.BgInstance.Audio.clip = BgScript.BgInstance.mainMenuClip;
        
        if(!BgScript.BgInstance.isPaused) {
            BgScript.BgInstance.Audio.Play();
        }
    }

   public void ExitGame()
    {
        Application.Quit();
    }
}
