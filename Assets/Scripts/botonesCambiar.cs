using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botonesCambiar : MonoBehaviour
{
      public GameObject EmpiezaJuego;
  public void GotoMainScene()
    {
        SceneManager.LoadScene(1);
    }

    public void GotoTutorialScene()
    {
        SceneManager.LoadScene(3);
    }

    public void GotoMini1Scene()
    {
        SceneManager.LoadScene(4);
    }
}
