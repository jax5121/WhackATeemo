using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private static Vector2 end_size;
    
    public int game_length;
    public int healingLength;
    public GameObject endGameScreen;

    private RectTransform rt;
    private double nextUpdate;
    private float timePassed;
    private float startWidth;

    private float healingTime;

    private Image image;

    private Vector2 healTo;

    private Text text;

    // Start is called before the first frame update
    void Start()
    {
        endGameScreen.SetActive(false);
        image = this.gameObject.GetComponent<Image>();
        rt = this.gameObject.GetComponent<RectTransform>();
        startWidth = rt.rect.height;
        end_size = new Vector2(0f, rt.rect.height);

        //debug time
        text = GameObject.Find("txtTime").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "";// + timePassed.ToString();
        if (RegenButton.active)
        {
            text.text = "Regen Power Active";
            image.color = Color.green;           
        }
        else if (rt.sizeDelta != end_size)
        {
            image.color = Color.red;
            rt.sizeDelta = Vector2.MoveTowards(rt.sizeDelta, end_size, Time.deltaTime * game_length);            
        }
        else
        {
            endGameScreen.SetActive(true);
        }

    }
}
