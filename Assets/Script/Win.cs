using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGUI(){
        if(GUI.Button(new Rect(Screen.width/2 -100f, Screen.height/2-100f, 200f,200f), "You Win~!")){
            SceneManager.LoadScene("Game");
        }
    }
}
