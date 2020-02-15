using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class respaldoMiniAntes : MonoBehaviour
{
   public minijuego1 minijuego;
   public Text pregunta,puntaje;
   public Color ncolor;
   private int puntajeInt=0;
   private int TiempoLimite=60;
   private int npregunta=1;
   public GameObject roundEndDisplay;
public GameObject questionPanelDisplay;


   void Start()
   {
      ncolor = minijuego.color[0];
      
      pregunta.text = minijuego.preguntas[0];
      //minijuego.objeto[1].GetComponent<Renderer>().material.color = ncolor;
      Instantiate(minijuego.objeto[0], new Vector3(30.0f,-5.0f,-5.0f), Quaternion.Euler(-10f, 0f, 0f));
      Instantiate(minijuego.objeto[0], new Vector3(-10.0f,-5.0f,-5.0f),Quaternion.identity);

   }

   public void OnMouseOver(){
               if(Input.GetMouseButtonUp(0))
        {
           if(npregunta==1 )
             {
                 ncolor = minijuego.color[1];
      
      pregunta.text = minijuego.preguntas[1];
      //minijuego.objeto[1].GetComponent<Renderer>().material.color = ncolor;
      Instantiate(minijuego.objeto[2], new Vector3(30.0f,-5.0f,-5.0f), Quaternion.Euler(-10f, 0f, 0f));
      Instantiate(minijuego.objeto[3], new Vector3(-10.0f,-5.0f,-5.0f),Quaternion.identity);
      npregunta++;

             }
             else if(npregunta==2 )
             {
                  ncolor = minijuego.color[2];
      
      pregunta.text = minijuego.preguntas[2];
      //minijuego.objeto[1].GetComponent<Renderer>().material.color = ncolor;
      Instantiate(minijuego.objeto[4], new Vector3(30.0f,-5.0f,-5.0f), Quaternion.Euler(-10f, 0f, 0f));
      Instantiate(minijuego.objeto[5], new Vector3(-10.0f,-5.0f,-5.0f),Quaternion.identity);
             npregunta++;
             }
             else if(npregunta==3 )
             {
                 ncolor = minijuego.color[3];
      
      pregunta.text = minijuego.preguntas[3];
      //minijuego.objeto[1].GetComponent<Renderer>().material.color = ncolor;
      Instantiate(minijuego.objeto[6], new Vector3(30.0f,-5.0f,-5.0f), Quaternion.Euler(-10f, 0f, 0f));
      Instantiate(minijuego.objeto[7], new Vector3(-10.0f,-5.0f,-5.0f),Quaternion.identity);
      npregunta++;
             }
            else  if(npregunta==4 )
             {
                  ncolor = minijuego.color[4];
      
      pregunta.text = minijuego.preguntas[4];
      //minijuego.objeto[1].GetComponent<Renderer>().material.color = ncolor;
      Instantiate(minijuego.objeto[8], new Vector3(30.0f,-5.0f,-5.0f), Quaternion.Euler(-10f, 0f, 0f));
      Instantiate(minijuego.objeto[9], new Vector3(-10.0f,-5.0f,-5.0f),Quaternion.identity);
      npregunta++;
             }
 else  if(npregunta==5 )
             {
                 questionPanelDisplay.SetActive(false);
    roundEndDisplay.SetActive(true);
   }
        }
   }


}
