using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MudançaDeObjetos : MonoBehaviour
{

    public GameObject imageDark;
    public GameObject imageNormal;



    public void TrocaImagem()
    {
        
        imageDark.SetActive(false);
        imageNormal.SetActive(true);
    }


}
