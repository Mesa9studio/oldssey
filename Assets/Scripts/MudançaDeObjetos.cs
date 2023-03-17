using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MudançaDeObjetos : MonoBehaviour
{

    // public GameObject caixaRegistradoraDark;
    // public GameObject caixaRegistradoraNormal;
    public string idItem;
    public Animator anim;
    // public RectTransform position;
   void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) // Botão esquerdo do mouse
        {
           if(anim.GetBool("clicked") == true)
            {
                Inventory.InventoryInstance.AddItem(idItem);
                gameObject.SetActive(false);
            }
        }
    }
   
    public void ObjectClicked()
    {
        if(!anim.GetBool("clicked"))
        {

            anim.SetBool("clicked", true);
        }
        
    }
    public void DestroyObject()
    {
        if(anim.GetBool("clicked") == true)
        {
            gameObject.SetActive(false);
        }
    }
}
