using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject painelGameOver;
    
   

    public void Menu()
    {
        SceneManager.LoadScene("inicial_menu");
       
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("CenaInventario");
       
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
