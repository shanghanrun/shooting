using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float  moveAmt = Input.GetAxis("Horizontal")*speed *Time.deltaTime;
        transform.Translate(Vector3.right *moveAmt);

        if(Input.GetKeyDown(KeyCode.Space)){
            GetComponent<AudioSource>().Play();
            Instantiate(bullet, transform.position,transform.rotation);
        }
    }
}
