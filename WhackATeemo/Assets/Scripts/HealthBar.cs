using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public static Vector2 new_size;
    
    public int game_length;

    private RectTransform rt;
    private float unit;
    private double nextUpdate;

    // Start is called before the first frame update
    void Start()
    {
        rt = this.gameObject.GetComponent<RectTransform>();
        Debug.Log(rt.rect.width);
        new_size = new Vector2(rt.rect.width, rt.rect.height);
        unit = rt.rect.width / game_length;
        //InvokeRepeating("Update", 0, 1.0f);
        nextUpdate = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextUpdate)
        {
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
            if (new_size.x <= 0)
            {
                new_size.x = 0;
                //game over
            }
            else
            {
                new_size.x -= unit;                
            }
            
            rt.sizeDelta = new_size;
        }

        //rt. = Mathf.Lerp(.x, 0f, Time.deltaTime * 0.10f);
        //rt.localScale = new_size;

    }
}
