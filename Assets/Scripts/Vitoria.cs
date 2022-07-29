using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vitoria : MonoBehaviour
{
    public GameObject painelWin;
    void Start()
    {
        StartCoroutine(GameWin());
    }

    IEnumerator GameWin()
    {
        yield return new WaitForSeconds(3);        
        painelWin.SetActive(true);
        
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
