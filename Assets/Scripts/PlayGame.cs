using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayGame : MonoBehaviour {

        public GameObject PanelCredits;
        public GameObject PanelConfig;
        // public AudioSource Audio;

        private void Update() {

                if (BgScript.BgInstance.isPaused)
                {
                        GameObject.Find("ButtonMusic").GetComponentInChildren<Text>().text = "Music OFF";
                }
                if (SfxScript.SfxInstance.isPaused)
                {
                        GameObject.Find("ButtonSound").GetComponentInChildren<Text>().text = "Sound OFF";
                }
        }

        public void StartGame() {

                    SceneManager.LoadScene("Intro");
                // SceneManager.LoadScene("CenaInventario");

                    BgScript.BgInstance.Audio.clip = BgScript.BgInstance.cutsceneClip;
                // BgScript.BgInstance.Audio.clip = BgScript.BgInstance.gameplayClip;
                if(!BgScript.BgInstance.isPaused) {
                BgScript.BgInstance.Audio.Play();
                }
                    
        }

        public void ShowConfig() {
               if(PanelConfig != null) {
                        PanelConfig.SetActive(true);
                }
                Debug.Log("Abriu config");
        }

        public void ShowCredits() {
                if(PanelCredits != null) {
                        PanelCredits.SetActive(true);
                }
                Debug.Log("Abriu créditos");

        }

        public void CloseCredits() {
              if(PanelCredits != null) {
                        PanelCredits.SetActive(false);
                }
              Debug.Log("Créditos fechado");
        }

        public void CloseConfig() {
              if(PanelConfig != null) {
                        PanelConfig.SetActive(false);
                }
              Debug.Log("Configurações fechadas");
        }

        public void ChangeSound() {
              if (GameObject.Find("ButtonSound").GetComponentInChildren<Text>().text == "Sound ON") {

                        // SfxScript.SfxInstance.Audio.clip = SfxScript.SfxInstance.sfxOffClip;
                        // SfxScript.SfxInstance.Audio.Pause();
                        SfxScript.SfxInstance.isPaused = true;
                        SfxScript.SfxInstance.Audio.mute = !SfxScript.SfxInstance.Audio.mute;
                        
                        GameObject.Find("ButtonSound").GetComponentInChildren<Text>().text = "Sound OFF";

                        Debug.Log("Sound off");
              } else {
                        
                        // SfxScript.SfxInstance.Audio.Play();
                        SfxScript.SfxInstance.isPaused = false;
                        SfxScript.SfxInstance.Audio.mute = !SfxScript.SfxInstance.Audio.mute;
                        
                        GameObject.Find("ButtonSound").GetComponentInChildren<Text>().text = "Sound ON";
                        Debug.Log("Sound on");
              }
        }
        public void ChangeMusic() {

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

        public void OpenLinkAna() {
               Application.OpenURL("https://www.linkedin.com/in/anasofiasilvestre/");
        }
        public void OpenLinkDana() {
                Application.OpenURL("instagram.com/danaxbraga");
        }
        public void OpenLinkBruna() {
                Application.OpenURL("https://instagram.com/arts.bruna.queiroz");
        }
        public void OpenLinkBell() {
                Application.OpenURL("https://github.com/isarbela");
        }
        public void OpenLinkDandi() {
                Application.OpenURL("https://piratadandi.wixsite.com/dandi");
        }
        public void OpenLinkKellen() {
                Application.OpenURL("https://www.linkedin.com/in/kellen-karollyne-1681a9184/");
        }
        public void OpenLinkCharlotte() {
                Application.OpenURL("https://www.instagram.com/charlottebrunna/");
        }
        public void OpenLinkHeloisa() {
                Application.OpenURL("https://www.linkedin.com/in/helo%C3%ADsa-rodrigues-012a577b/");
        }

}
