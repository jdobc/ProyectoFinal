using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dataController : MonoBehaviour
{
    public roundData[] allRoundData;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        SceneManager.LoadScene(1);
    }

    public roundData GetCurrentRoundData(){
        return allRoundData[0];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
