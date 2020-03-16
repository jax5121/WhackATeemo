using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public static int attacks;
    
    private Vector2 end_size;
    
    public float gameLength;
    public GameObject endGameScreen;

    private RectTransform rt;
    private RectTransform burstRt;
    private float timePassed;
    private float speed;
    private float bgSpeed;

    private Image image;

    private Vector2 healTo;

    private Text text;

    // Start is called before the first frame update
    void Start()
    {
        attacks = 0;
        endGameScreen.SetActive(false);
        image = this.gameObject.GetComponent<Image>();
        rt = this.gameObject.GetComponent<RectTransform>();
        burstRt = GameObject.Find("BurstBar").GetComponent<RectTransform>();
        end_size = new Vector2(0f, rt.rect.height);

        //pre calculate speed for update method
        speed = Vector2.Distance(rt.sizeDelta, end_size) / gameLength;
        bgSpeed = 40f / 0.25f;

        //debug time
        text = GameObject.Find("txtTime").GetComponent<Text>();
    }

    void TakeDamage()
    {
        Vector2 postDamage = rt.sizeDelta;
        postDamage.x -= 40f;
        rt.sizeDelta = postDamage;
        attacks--;
    }

    // Update is called once per frame
    void Update()
    {
        //text.text = "";
        if (attacks > 0)
        {
            TakeDamage();
        }
        
        if (StasisButton.active)
        {
            text.text = "Regen Power Active";
            image.color = Color.yellow;           
        }
        else if (rt.sizeDelta.x > 0f)
        {
            image.color = Color.red;
            rt.sizeDelta = Vector2.MoveTowards(rt.sizeDelta, end_size, speed * Time.deltaTime);
            //burstRt.sizeDelta = Vector2.MoveTowards(burstRt.sizeDelta, rt.sizeDelta, bgSpeed * Time.deltaTime);
        }
        else
        {
            TargetControllerScript.spawn = false;
            endGameScreen.SetActive(true);
        }
        //if player is damaged and time ends then this will decrease burstbar after timer ends
        if (burstRt.sizeDelta.x > 0f) burstRt.sizeDelta = Vector2.MoveTowards(burstRt.sizeDelta, rt.sizeDelta, bgSpeed * Time.deltaTime);
    }
}
