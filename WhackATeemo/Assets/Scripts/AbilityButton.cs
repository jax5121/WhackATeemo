using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AbilityButton : MonoBehaviour
{
    public static bool active;
    public static bool onCoolDown;

    public int coolDown;
    public string abilityName;
    
    protected float timePassed;
    private int secondsLeft;
    public Button button;      
    public Text text;

    public void ActivatePower()
    {
        active = true;
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        text.text = abilityName;
    }

    // Update is called once per frame
    protected virtual void Update() 
    {
        button.interactable = !onCoolDown;
        if (onCoolDown)
        {
            timePassed += Time.deltaTime;
            secondsLeft = coolDown - Convert.ToInt32(timePassed);
            text.text = secondsLeft.ToString();
            if (timePassed >= coolDown)
            {
                onCoolDown = false;
                timePassed = 0;
                text.text = abilityName;
            }
        }
    }
}
