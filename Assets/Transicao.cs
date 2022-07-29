using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Transicao : MonoBehaviour
{
    public Animator transicao;
    public float tempoTransicao = 1f;
    void Update()
    {
        if(Input.touchCount > 0)
        {
            LoadNextScene();
        }
        
    }

    public void LoadNextScene()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
       
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transicao.SetTrigger("Start");

        yield return new WaitForSeconds(tempoTransicao);

        SceneManager.LoadScene(levelIndex);
    }
}
