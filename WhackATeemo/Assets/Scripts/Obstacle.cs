using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject target; 

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn",Random.Range(2, 10));
    }


    void Spawn()
    {
        
        GameObject g = Instantiate(target, new Vector3(transform.position.x, transform.position.y, 1), Quaternion.identity);
        Invoke("Spawn", Random.Range(2, 10));
    }

    
}
