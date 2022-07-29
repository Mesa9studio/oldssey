using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject painelGameOver;
    
    void Start()
    {
        StartCoroutine(GameOverScene());
    }

    IEnumerator GameOverScene()
    {
        yield return new WaitForSeconds(2);
        painelGameOver.SetActive(true);
        

    }

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
