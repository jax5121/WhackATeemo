using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class StasisButton : AbilityButton
{
    public int length;

    

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update() // code specific to the ability
    {
        base.Update();
        if (active)
        {
            timePassed += Time.deltaTime;
            text.text = "INVINCIBLE";
            if (timePassed >= length)
            {
                timePassed = 0;
                active = false;
                onCoolDown = true;
            }
        }
    }
}
