using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int timer;
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
            Destroy(this.gameObject);
        }
        timer--;
    }

    void OnMouseDown() // need box collider for this to work
    {
        ScoreControllerScript.score++;
        Destroy(this.gameObject);
    }
}
