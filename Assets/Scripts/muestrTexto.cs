using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class muestrTexto : MonoBehaviour
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

     /*
    // Start is called before the first frame update
    public string MyString;
    public TMP_Text  myText;
    public float fadeTime;
    public bool displayInfo;

    void Start()
    {
        myText = GameObject.Find("Button").GetComponent<TMP_Text>();
        myText.color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
     FadeText();
     
    }

    void OnMouseOver(){
        
        myText.SetActive(true);
    }
     void OnMouseExit(){
       textMeshProUGUI.enabled = false;
    }

    void FadeText(){
        if(displayInfo){
            myText.text=MyString;
            myText.color=Color.Lerp(myText.color,Color.white,fadeTime*Time.deltaTime);
        }
        else{
            myText.color=Color.Lerp(myText.color,Color.white,fadeTime*Time.deltaTime);
        }
    }*/
}
