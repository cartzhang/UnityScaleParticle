using UnityEngine;
using System.Collections;

public class DestroyThisTimed : MonoBehaviour {

    public float DestroyTime = 5;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, DestroyTime);
	}	
}
