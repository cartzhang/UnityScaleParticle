using UnityEngine;
using System.Collections;

public class PlayGunAnimation : MonoBehaviour 
{
    Animator anim;
    public string ainmationName;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButton(0))
        {
            anim.Play(ainmationName);
        }
        else
        {
            anim.Play("Stop");
        }
	}
       

}
