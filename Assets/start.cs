using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start : MonoBehaviour
{

    public Text BestScore;
    // Start is called before the first frame update
    void Start()
    {
        int Best = PlayerPrefs.GetInt("Best");
        BestScore.text = "best: " + Best;
        script.BestScore = Best;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
