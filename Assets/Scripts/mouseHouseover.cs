using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mouseHouseover : MonoBehaviour
{
        public int levelToLoad;
public AudioClip soundhover;
public bool QuitButton=false;
    void OnMouseOver(){
        if(Input.GetMouseButtonUp(0))
        {
            //Debug.Log("Hola");
            GetComponent<AudioSource>().PlayOneShot(soundhover);
            if(QuitButton){
Application.Quit();
}
else{
SceneManager.LoadScene(levelToLoad);
}
        }
        }
    // Start is called before the first frame update
}
