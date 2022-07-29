using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScript : MonoBehaviour
{
        public static BgScript BgInstance = null;
        public AudioSource Audio;

        private void Awake() {

            if(BgInstance != null && BgInstance != this) {
                Destroy(gameObject);

            } else {

                BgInstance = this;
                DontDestroyOnLoad(gameObject);
            }    

           

        }

        

        private void Start() {
             Audio = GetComponent<AudioSource>();
        }
}
