using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    static public int Score =0;
    static public int Lives = 3;
    public int FinishScore =1000;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Score >= FinishScore){
            Score =0;
            SceneManager.LoadScene("Win");
        }
    }

    void OnGUI(){
        GUI.Label(new Rect(10f, 10f, 200f, 20f), Main.Score.ToString());
        GUI.Label(new Rect(10f, 30f,200f,20f), Main.Lives.ToString()); 
    }
}
