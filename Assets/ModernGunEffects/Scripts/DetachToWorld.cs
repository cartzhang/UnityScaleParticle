using UnityEngine;
using System.Collections;

public class DetachToWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.transform.parent = null;
	}
}
