using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Quit");
            //if (UnityEditor.EditorApplication.isPlaying == true)
            //{
            //    UnityEditor.EditorApplication.isPlaying = false;
            //}
            Application.Quit();
        }

        //if (Input.GetKey(KeyCode.Space))
        //{
        //    Debug.Log("Space");
        //    UnityEditor.EditorApplication.isPaused = !UnityEditor.EditorApplication.isPaused;            
        //    Application.Quit();
        //}
	
	}

  
}
