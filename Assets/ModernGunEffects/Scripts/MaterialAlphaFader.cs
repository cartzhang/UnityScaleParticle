using UnityEngine;
using System.Collections;

public class MaterialAlphaFader : MonoBehaviour 
{
    public float fadeSpeed = 1.0f;
    public float beginTintAlpha = 0.5f;
    public Color myColor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        beginTintAlpha -= Time.deltaTime * fadeSpeed;
        GetComponent<Renderer>().material.SetColor("_TintColor", new Color(myColor.r, myColor.g, myColor.b, beginTintAlpha));
	}
}
