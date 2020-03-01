using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerData : MonoBehaviour
{
   public minijuego1 minijuego;
   public Text pregunta,puntaje,cambia,respuestab,respuestaa;
   private Color ncolor;
   public int puntajeInt=0;
   private int TiempoLimite=60;
   private int npregunta=1;
   public GameObject roundEndDisplay;
public GameObject questionPanelDisplay;

private GameObject clone1,clone2,clone3,clone4,clone5,clone6,clone7,clone8,clone9,clone10;


   void Start()
   {
      ncolor = minijuego.color[0];
      cambia.text = minijuego.cambiarcolor[0];  
      cambia.color = ncolor;
      pregunta.text = minijuego.preguntas[0]+cambia.text;
      //minijuego.objeto[1].GetComponent<Renderer>().material.color = ncolor;
      clone1 = Instantiate(minijuego.objeto[0], new Vector3(30.0f,-5.0f,-5.0f), Quaternion.Euler(-10f, 0f, 0f));
      clone2 = Instantiate(minijuego.objeto[1], new Vector3(-10.0f,-5.0f,-5.0f),Quaternion.identity);
      if(respuestab.ToString() == minijuego.respuesta[0] ){
      puntajeInt++;
      cambia.text= "Puntaje : " +puntajeInt.ToString();
      }
      else
      cambia.text= "Puntaje : " +puntajeInt.ToString();
   }

   public void Siguiente(){
               
           if(npregunta==1 )
             {
                Destroy(clone1,0.0f);
                Destroy(clone2,0.0f);
                 ncolor = minijuego.color[1];
      
      pregunta.text = minijuego.preguntas[1]+minijuego.cambiarcolor[1];
      minijuego.objeto[1].GetComponent<Renderer>().material.color = ncolor;
      clone3 = Instantiate(minijuego.objeto[2], new Vector3(30.0f,-5.0f,-5.0f), Quaternion.Euler(-10f, 0f, 0f));
      clone4 = Instantiate(minijuego.objeto[3], new Vector3(-10.0f,-5.0f,-5.0f),Quaternion.identity);
      npregunta++;
      if(respuestab.ToString() == minijuego.respuesta[1] ){
      puntajeInt++;
      cambia.text= "Puntaje a: " +puntajeInt.ToString();
      }
      else
      cambia.text= "Puntaje a: " +puntajeInt.ToString();
             }
             else if(npregunta==2 )
             {
                Destroy(clone3,0.0f);
                Destroy(clone4,0.0f);
                  ncolor = minijuego.color[2];
      
      pregunta.text = minijuego.preguntas[2]+minijuego.cambiarcolor[2];
      //minijuego.objeto[1].GetComponent<Renderer>().material.color = ncolor;
      clone5 = Instantiate(minijuego.objeto[4], new Vector3(30.0f,-5.0f,-5.0f), Quaternion.Euler(-10f, 0f, 0f));
      clone6 = Instantiate(minijuego.objeto[5], new Vector3(-10.0f,-5.0f,-5.0f),Quaternion.identity);
             npregunta++;
             if(respuestab.ToString() == minijuego.respuesta[2] ){
      puntajeInt++;
      cambia.text= "Puntaje a: " +puntajeInt.ToString();
      }
      else
      cambia.text= "Puntaje a: " +puntajeInt.ToString();
             }
             else if(npregunta==3 )
             {
                Destroy(clone6,0.0f);
                Destroy(clone5,0.0f);
                 ncolor = minijuego.color[3];
      
      pregunta.text = minijuego.preguntas[3]+minijuego.cambiarcolor[3];
      //minijuego.objeto[1].GetComponent<Renderer>().material.color = ncolor;
      clone7 = Instantiate(minijuego.objeto[6], new Vector3(30.0f,-5.0f,-5.0f), Quaternion.Euler(-10f, 0f, 0f));
      clone8 = Instantiate(minijuego.objeto[7], new Vector3(-10.0f,-5.0f,-5.0f),Quaternion.identity);
      npregunta++;
      if(respuestab.ToString() == minijuego.respuesta[3] ){
      puntajeInt++;
      cambia.text= "Puntaje b: " +puntajeInt.ToString();
      }
      else
      cambia.text= "Puntaje b: " +puntajeInt.ToString();
             }
            else  if(npregunta==4 )
             {
                Destroy(clone7,0.0f);
                Destroy(clone8,0.0f);
                  ncolor = minijuego.color[4];
      
      pregunta.text = minijuego.preguntas[4]+minijuego.cambiarcolor[4];
      //minijuego.objeto[1].GetComponent<Renderer>().material.color = ncolor;
      clone9=Instantiate(minijuego.objeto[8], new Vector3(30.0f,-5.0f,-5.0f), Quaternion.Euler(-10f, 0f, 0f));
      clone10=Instantiate(minijuego.objeto[9], new Vector3(-10.0f,-5.0f,-5.0f),Quaternion.identity);
      npregunta++;
      if(respuestab.ToString() == minijuego.respuesta[4] ){
      puntajeInt++;
      cambia.text= "Puntaje c: " +puntajeInt.ToString();
      }
      else
      cambia.text= "Puntaje c: " +puntajeInt.ToString();
             }
 else  if(npregunta==5 )
             {
                Destroy(clone9,0.0f);
                Destroy(clone10,0.0f);
                 questionPanelDisplay.SetActive(false);
    roundEndDisplay.SetActive(true);
     cambia.text= "Puntaje final: " +puntajeInt.ToString();
   }
        
   }


}
