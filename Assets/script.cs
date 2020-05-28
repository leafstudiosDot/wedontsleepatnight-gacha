using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class script : MonoBehaviour
{

    public static int Score;
    public static int BestScore;
    public Animator animator;
    public Text number;
    public GameObject Touch;

    // Start is called before the first frame update
    void Start()
    {

        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            Touch.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            number.text = "Number of Screen Pressed: " + Score;
        }
        else if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.LinuxPlayer)
        {
            number.text = "Number of Space Bar Pressed: " + Score;
        }
        else if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.LinuxEditor)
        {
            number.text = "Number of Space Bar Pressed: " + Score;
        }

        if (Score%2 == 1)
        {
            animator.SetBool("odd", true);
        } else
        {
            animator.SetBool("odd", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Score += 1;
        }
    }

    public void AddScore()
    {
        Score += 1;
    }

    public static void ToGame()
    {
        SceneManager.LoadScene("Party");
    }

    public static void FinishGame()
    {
        SceneManager.LoadScene("TotalScore");
    }

    public static void Scorelist()
    {
        SceneManager.LoadScene("Scorelists");
    }
}
