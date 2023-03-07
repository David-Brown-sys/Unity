using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copysp : MonoBehaviour
{
    public GameObject sp;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 ve3 = new Vector3(Random.Range(-5.0f, 5.0f), 2.0f, Random.Range(-5.0f, 5.0f));
            Instantiate(sp, ve3, Quaternion.identity);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
