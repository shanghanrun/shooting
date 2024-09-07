using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 8f;
    public GameObject explosion;
    private bool isHit = false; // 충돌상태를 저장하는 플래그
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
            isHit = false;
        }
    }
    void InitPosition(){
        transform.position = new Vector3(Random.Range(-5, 5), 7f, 0f);
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag =="bullet" && !isHit){
            isHit = true;
            Main.Score +=100;
            GetComponent<AudioSource>().Play();
            GameObject newExplosion = Instantiate(explosion, transform.position,transform.rotation);
            Destroy(newExplosion, 2f); //효과는 나타나고, 2초후 사라지게
            InitPosition();
            isHit = false;
        }
    }
}
