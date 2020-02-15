using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class muestraMenu : MonoBehaviour
{
    public GameObject Texto;
    
    public void Start(){
        Texto.SetActive(false);
    }

    public void OnMouseOver(){
        Texto.SetActive(true);
    }

    public void OnMouseExit(){
        Texto.SetActive(false);
    }

   
}
