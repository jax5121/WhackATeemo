using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControllerScript : MonoBehaviour
{
    Text txt;
    public static int score;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Score: " + score;
    }
}
