using UnityEngine;
using System.Collections;

public class PlayParticle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey(KeyCode.P))
        {
            this.GetComponent<ParticleSystem>().Play();
        }
	
	}
}
