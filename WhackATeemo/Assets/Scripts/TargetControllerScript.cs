using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetControllerScript : MonoBehaviour
{
    public static bool spawn;
    public GameObject prefab;
    public GameObject[] prefabList;
    public GameObject[] spawnPoints;
    

    // Start is called before the first frame update
    void Start()
    {
        spawn = true;

        //create spawnpoint list
        spawnPoints = GameObject.FindGameObjectsWithTag("obstacle");
        
        Debug.Log(spawnPoints.Length);

        prefabList = new GameObject[spawnPoints.Length];

        for(int i = 0; i < prefabList.Length; i++)
        {
            prefabList[i] = prefab;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn)
        {        
            int rand = Random.Range(0, 1000);
            if (rand > 970)
            {
                int sp = Random.Range(0, spawnPoints.Length);
                float x = spawnPoints[sp].transform.position.x;
                float y = spawnPoints[sp].transform.position.y + 50;
                Instantiate(prefabList[sp], new Vector3(x,y,0), Quaternion.identity);
        
            }
        }
    }
}
