using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public bool spawn;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spawn)
        {        
            int rand = Random.Range(0, 100);
            if (rand > 90)
            {
                int x = Random.Range(0, 18);
                int y = Random.Range(0, 10);
                Instantiate(prefab, new Vector3(x,y,0), Quaternion.identity);
        
            }
        }
    }
}
