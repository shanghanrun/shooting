using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 8f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAmt = speed * Time.deltaTime;
        transform.Translate(Vector3.down * moveAmt);

        if(transform.position.y <-7f){
            InitPosition();
        }
    }
    void InitPosition(){
        transform.position = new Vector3(Random.Range(-5, 5), 7f, 0f);
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag =="bullet"){
            InitPosition();
        }
    }
}
