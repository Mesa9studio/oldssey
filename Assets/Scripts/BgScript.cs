using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BgScript : MonoBehaviour
{
        public static BgScript BgInstance = null;
        public AudioSource Audio;
        public AudioClip cutsceneClip;
        public AudioClip gameplayClip;
        public AudioClip victoryClip;
        public AudioClip gameoverClip;
        public AudioClip mainMenuClip;
        public AudioClip fastMusicClip;
        public AudioClip fast2xMusicClip;
        public bool isPaused = false;

        private void Awake() {

            if(BgInstance != null && BgInstance != this) {
                Destroy(gameObject);

            } else {

                BgInstance = this;
                DontDestroyOnLoad(gameObject);
            }    

        }

        // void Update() {
            
        // } 

        private void Start() {
             Audio = GetComponent<AudioSource>();
        }
}
