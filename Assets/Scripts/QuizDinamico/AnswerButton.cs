using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    public Text answerText;
    private preguntasData answerData;
    private GameController gameController;
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }
    public void Setup(preguntasData data){
        answerData=data;
        answerText.text=answerData.preguntasTexto;
            }
    
    public void HandleClick()
    {
        //gameController.AnswerButtonClicked(answerData.isCorrect);
    }
}
