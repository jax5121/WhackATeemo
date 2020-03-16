using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int timer;
    public int worth;
    public bool inUse;
    // Start is called before the first frame update
    void Start()
    {
        inUse = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer == 0) // attacks player and disappears
        {
            HealthBar.attacks++;
            Destroy(this.gameObject);
        }
        timer--;
    }

    void OnMouseDown() // need box collider for this to work
    {
        if (StasisButton.active) worth = 2;
        ScoreControllerScript.score+=worth;
        Destroy(this.gameObject);
    }
}
