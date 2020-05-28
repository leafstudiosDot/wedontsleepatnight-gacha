using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroToParty : MonoBehaviour
{
    private float seconds = 3.544f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float timeElapsed;
    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > seconds)
        {
            script.ToGame();
        }
    }
}
