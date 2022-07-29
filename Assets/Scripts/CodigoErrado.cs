using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#pragma strict

public class CodigoErrado : MonoBehaviour

{
    //private Touch toqueTela;
    public VoltarAoJogo volta;
    public Sprite [] baterias = new Sprite[4];
    public Image bateriaImagem;
    public float tempoInicial, tempoStart;
    public bool tempoAcabou;
    public Text segundos;
    private int vida_personagem;
    private int bateria = 4;
    public GameObject PainelGameOver;

   // private bool isPaused;
   // public string cena;
   // public GameObject pauseMenu;


    private void Start()
    {
        Time.timeScale = 1f;
        tempoInicial = tempoStart;
        bateria = 4;
    }

    private void Update()
    {
        if (!tempoAcabou)
        {
            ContagemRegressiva();
        } else {
            Debug.Log("AAAAAAAAA");
            volta.GameOver();
        }

        if (bateria == 0)
        {
            //chamar game over aqui
            PainelGameOver.SetActive(true);
            volta.GameOver();
        }

       // }

      /*  if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            TelaPause();

        }*/

    }

   /* public void TelaPause()
    {
        if (isPaused)
        {
            isPaused = false;
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
        }
        else
        {
            isPaused = true;
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);

        }
    }*/

    public void ContagemRegressiva()
    {
        tempoInicial -= 1 * Time.deltaTime;
        segundos.text = tempoInicial.ToString("0");
        if (tempoInicial > 0)
        {
            tempoAcabou = false;
        }
        if (tempoInicial < 0)
            tempoAcabou = true;
    }

    public void TiraBateria(){
        Debug.Log(bateria);
        bateria--;
        bateriaImagem.sprite = baterias[bateria-1];
    }


}
