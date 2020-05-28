using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userlists : MonoBehaviour
{

    // Start is called before the first frame update
    IEnumerator Start()
    {
        WWW lists = new WWW("http://prototypes.rf.gd/sleeptonight/listuser.php");
        yield return lists;
        string[] webResults = lists.text.Split('/');
        foreach (string s in webResults)
        {
            Debug.Log(s);
        }
    }
}
