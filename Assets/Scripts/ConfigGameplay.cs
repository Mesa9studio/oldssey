using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfigGameplay : MonoBehaviour
{
    public AudioSource Audio;
    public GameObject PanelCredits;
    public GameObject PanelConfig;

    public void CloseCredits()
    {
        if (PanelCredits != null)
        {
            PanelCredits.SetActive(false);
        }
        Debug.Log("Cr�ditos fechado");
    }

    public void CloseConfig()
    {
        if (PanelConfig != null)
        {
            PanelConfig.SetActive(false);
        }
        Debug.Log("Configura��es fechadas");
    }

    public void ChangeSound()
    {
        if (GameObject.Find("ButtonSound").GetComponentInChildren<Text>().text == "Sound ON")
        {

            SfxScript.SfxInstance.Audio.clip = SfxScript.SfxInstance.sfxOffClip;
            SfxScript.SfxInstance.Audio.Play();
            SfxScript.SfxInstance.Audio.mute = !SfxScript.SfxInstance.Audio.mute;

            GameObject.Find("ButtonSound").GetComponentInChildren<Text>().text = "Sound OFF";
            Debug.Log("Sound off");
        }
        else
        {

            SfxScript.SfxInstance.Audio.Play();
            SfxScript.SfxInstance.Audio.mute = !SfxScript.SfxInstance.Audio.mute;

            GameObject.Find("ButtonSound").GetComponentInChildren<Text>().text = "Sound ON";
            Debug.Log("Sound on");
        }
    }
    public void ChangeMusic()
    {
        if(BgScript.BgInstance.Audio.isPlaying) {

                BgScript.BgInstance.Audio.Pause();
                BgScript.BgInstance.isPaused = true;

                Debug.Log("Music geral off");

                GameObject.Find("ButtonMusic").GetComponentInChildren<Text>().text = "Music OFF";
        } else {
                BgScript.BgInstance.Audio.Play();
                BgScript.BgInstance.isPaused = false;

                Debug.Log("Music geral On");

                GameObject.Find("ButtonMusic").GetComponentInChildren<Text>().text = "Music ON";
        }
    }
}
