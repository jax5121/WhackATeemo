using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AbilityButton : MonoBehaviour
{
    public static bool active;
    
    public int length;
    public string abilityName;
    public Button button;    
    
    public Text text;
    private float timePassed;
    private int secondsPassed;

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
        Debug.Log("button2 update");
        button.interactable = !active;
        if(active)
        {
            timePassed += Time.deltaTime;
            secondsPassed = Convert.ToInt32(timePassed);
            text.text = secondsPassed.ToString();
            if (timePassed >= length)
            {
                active = false;
                timePassed = 0;
                text.text = abilityName;
            }
        }
    }
}
