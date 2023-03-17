using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SfxScript : MonoBehaviour
{
        public static SfxScript SfxInstance = null;
        public AudioSource Audio;
        public AudioClip senhorTriste;
        public AudioClip senhorFeliz;
        public AudioClip maquinaRegistradora;
        public AudioClip cesta;
        
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

        public void SenhorTristePlay()
        {
            Audio.clip = senhorTriste;
            Audio.Play();
        }
        public void SenhorFelizPlay()
        {
            Audio.clip = senhorFeliz;
            Audio.Play();
        }
        public void MaquinaRegistradoraePlay()
        {
            Audio.clip = senhorTriste;
            Audio.Play();
        }
        public void CestaPlay()
        {
            Audio.clip = senhorTriste;
            Audio.Play();
        }
}
