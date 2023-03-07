using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float speed2 = 40.0f;//弹出时的速度
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);//销毁对象
            Application.Quit();
        }
    }
    void OnCollisionEnter(Collision collision)
    {   //当球落到板上时给他一个力弹出去
        rb.AddForce(new Vector3 (Random.Range (-0.2f, 0.2f), 1.0f, 0) * speed2);
    }
}
