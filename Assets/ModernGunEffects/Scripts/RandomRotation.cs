using UnityEngine;
using System.Collections;

public class Radk : MonoBehaviour {

    public float rotationMaxX = 0.0f;
    public float rotationMaxY = 360.0f;
    public float rotationMaxZ = 0.0f;
    // Use this for initialization
    void Start()
    {
        var rotX = Random.Range(-rotationMaxX, rotationMaxX);
        var rotY = Random.Range(-rotationMaxY, rotationMaxY);
        var rotZ = Random.Range(-rotationMaxZ, rotationMaxZ);

        this.transform.Rotate(rotX, rotY, rotZ);
    }
}
