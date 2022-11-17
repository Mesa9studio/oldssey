using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MudançaDeObjetos : MonoBehaviour
{

    public GameObject caixaRegistradoraDark;
    public GameObject caixaRegistradoraNormal;



    void Update()
    {
       

        if(Input.touchCount > 0)
        {
            caixaRegistradoraDark.SetActive(false);
            caixaRegistradoraNormal.SetActive(true);
        }
    }


}
