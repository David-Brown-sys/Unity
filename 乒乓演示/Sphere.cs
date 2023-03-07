using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float speed2 = 40.0f;//����ʱ���ٶ�
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
            Destroy(gameObject);//���ٶ���
            Application.Quit();
        }
    }
    void OnCollisionEnter(Collision collision)
    {   //�����䵽����ʱ����һ��������ȥ
        rb.AddForce(new Vector3 (Random.Range (-0.2f, 0.2f), 1.0f, 0) * speed2);
    }
}
