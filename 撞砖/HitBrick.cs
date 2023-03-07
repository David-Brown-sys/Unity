using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBrick : MonoBehaviour
{
    public GameObject Brick;
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < 8; i++)
        {
            Vector3 vector3 = new Vector3(Random.Range(-8.0f, 8.0f), 0.5f, Random.Range(-8.0f, 8.0f));
            GameObject.Instantiate(Brick, vector3, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray;
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,out hit))
            {   //子弹的实例化
                GameObject bt = GameObject.Instantiate(Bullet, transform.position, Quaternion.identity);
                Vector3 dis = hit.point - transform.position;
                //鼠标点击的方向减去摄像机的方向
                bt.GetComponent<Rigidbody>().AddForce(dis * 300); 
            }
        }
    }
}
