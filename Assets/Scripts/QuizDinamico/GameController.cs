using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
public Text scoreDisplayText;
public Text questionDisplayText;
public SimpleObjectPool answerButtonObjectPool;
public Transform answerButtonParent;
public GameObject questionPanelDisplay;
public GameObject roundEndDisplay;

    private dataController DataController;
    private roundData currentRoundData;
    private preguntasData[] questionPool;
    private bool isRoundActive;
    private float tiemporestante;
    private int questionIndex;
    private int puntaje;
    private List<GameObject> answerButtonGameObjects = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        DataController = FindObjectOfType<dataController>();
        currentRoundData = DataController.GetCurrentRoundData ();
        questionPool = currentRoundData.questions;
        tiemporestante = currentRoundData.limiteDeTiempo;

        puntaje = 0;
        questionIndex = 0;
        MuestraPregunta();
        isRoundActive = true;

    }

    private void MuestraPregunta(){
        QuitaBotonesdeResouesta();
        preguntasData _PreguntasData = questionPool[questionIndex];
        questionDisplayText.text = _PreguntasData.preguntasTexto;

        for(int i=0;i<_PreguntasData.answers.Length;i++)
        { 
            GameObject answerButtonGameObject= answerButtonObjectPool.GetObject();
            answerButtonGameObject.transform.SetParent(answerButtonParent);
            answerButtonGameObjects.Add(answerButtonGameObject);

            AnswerButton answerButton = answerButtonGameObject.GetComponent<AnswerButton>();
            //answerButton.Setup(_PreguntasData.answers[i]);
            
        }
    }
    
    public void AnswerButtonClicked(bool isCorrect){
        if(isCorrect)
        {
            //puntaje += currentRoundData.pointsAddedForpuntaje;
            scoreDisplayText.text = "Score: " + puntaje.ToString();
        }
        if(questionPool.Length>questionIndex+1)
        {
            questionIndex++;
            MuestraPregunta();
        }
        else{
            EndRound();
        }
    }

public void EndRound(){
    isRoundActive =false;
    questionPanelDisplay.SetActive(false);
    roundEndDisplay.SetActive(true);
}
    private void QuitaBotonesdeResouesta(){
        while (answerButtonGameObjects.Count>0)
        {
            answerButtonObjectPool.ReturnObject(answerButtonGameObjects[0]);
            answerButtonGameObjects.RemoveAt(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
