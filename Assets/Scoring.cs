using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Text TotalScore;
    public Text BestScore;
    public Text Reset;
    public Button ResetButton;

    public GameObject score;
    public GameObject zeroScore;
    public Text Message;
    // Start is called before the first frame update
    void Start()
    {
        int Score = script.Score;
        TotalScore.text = "Your score is " + Score;

        if (Score == 0)
        {
            score.SetActive(false);
            zeroScore.SetActive(true);
            ScrambleProtips();
        }

        if (script.BestScore <= script.Score)
        {
            print("less than");
            script.BestScore = script.Score;
            PlayerPrefs.SetInt("Best", script.BestScore);
        } else if (script.BestScore >= script.Score)
        {
            print("greater than");
        }
    }

    void Update()
    {
        BestScore.text = "best: " + script.BestScore;
    }

    public void ResetBest()
    {
        PlayerPrefs.DeleteKey("Best");
        Reset.text = "Done";
        ResetButton.enabled = false;
    }

    public void ScrambleProtips()
    {
        PickRandomFromList();
        Debug.Log(Message.text);
    }

    private void PickRandomNumber(int maxInt)
    {
        int randomNum = Random.Range(1, maxInt + 1);
        Message.text = randomNum.ToString();
    }

    private void PickRandomFromList()
    {
        string[] protips = new string[] {
            //Insert Protips here. 
            //Until 63 characters
            "dedicated to Carlo and Freya :D",
            "Blame Gabriel Pabelonia",
            "˙ǝɹǝɥ ןǝɐɥɔıW 'ǝɔnɐsΛ '¡ʎǝH",
            "Finally, Protip Generator works!",
            "My parents helped me test my game, I'm really shy.",
            "If you want to play the full game, You have to pay for it.",
            "Why not to take a screenshot of some protips here mate?",
            "Never gonna give you up, Never gonna let you down",
            "Gab is truly on drugs when he plays Arsenal on Roblox",
            "Tang inang edit iyan - Aurellio Dong",
            "Yes, dots hugged his classmate (girl)",
            "Moritz + Freya = Moreya",
            "Third Wheel pa kasi si Carlo Carabao",
            "Yappy Out!",
            "Aguhon Tang Orange Juice",
            "Tangalin mo yung Thanksgiving",
            "Thanksgiving",
            "Gab on drugs",
            "Thanos Snap",
            "Arsenal is the best game on Roblox",
            "Clarence",
            "Bonked by stress",
            "This took me a decade haha",
            "Does anyone has a juice",
            "Kool Aid looks so delicious to drink",
            "How to get drunk",
            "Smokin, Isn't it great?",
            "Dora the Xplorer",
            "Aguhon",
            "Does anyone heard about the Moreya before?",
            "Creepy",
            "You stressed me down, you killed me\nYou dragged me down, you f*cked me up"
        };
        string randomName = protips[Random.Range(0, protips.Length)];
        Message.text = randomName;
    }

}
