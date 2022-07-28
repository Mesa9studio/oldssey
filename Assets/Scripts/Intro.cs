using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(StartIntro());
    }

   IEnumerator StartIntro()
    {
        yield return new WaitForSeconds(26);
        SceneManager.LoadScene("CenaInventario");
    }
}