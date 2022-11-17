using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SfxScript : MonoBehaviour
{
        public static SfxScript SfxInstance = null;
        public AudioSource Audio;
        public AudioClip sfxOnClip;
        public AudioClip sfxOffClip;
        
        public bool isPaused = false;

        private void Awake() {

            if(SfxInstance != null && SfxInstance != this) {
                Destroy(gameObject);

            } else {

                SfxInstance = this;
                DontDestroyOnLoad(gameObject);
            }    

        }

        // void Update() {
            
        // } 

        private void Start() {
             Audio = GetComponent<AudioSource>();
        }
}
