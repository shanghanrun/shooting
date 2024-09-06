
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAmt = Time.deltaTime * speed;
        transform.Translate(Vector3.up * moveAmt);

        if(transform.position.y >7f){
            Destroy(gameObject);
        }
    }
}
