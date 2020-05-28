using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class submitscore : MonoBehaviour
{

    public InputField username; 
    public Text score; 
    public Button submit;
    public GameObject LoadingScreen;

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AddToData()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username.text);
        form.AddField("score", score.text);
        WWW www = new WWW("http://prototypes.rf.gd/sleeptonight/adduser.php", form);
        yield return www;
        if (www.text == "0")
        {
            SceneManager.LoadScene("ScoresByUser");
        } else
        {
            Application.Quit();
        }
    }

    public void CallAdd()
    {
        LoadingScreen.SetActive(true);
        StartCoroutine(AddToData());
    }

    public void VerifyInputs()
    {
        submit.interactable = (username.text.Length >= 1);
    }
}
