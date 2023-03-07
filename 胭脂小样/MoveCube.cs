using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    private Rigidbody ri;
    public float speed = 5.0f;
    public GameObject sp;
    // Start is called before the first frame update
    void Start()
    {
        ri = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            ri.MovePosition(transform.position + Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            ri.MovePosition(transform.position + Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            ri.MovePosition(transform.position + Vector3.left* speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            ri.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            Destroy(collision.gameObject);
            Vector3 ve3 = new Vector3(Random.Range(-5.0f, 5.0f), 2.0f, Random.Range(-5.0f, 5.0f));
            Instantiate(sp, ve3, Quaternion.identity);
        }
    }
}
