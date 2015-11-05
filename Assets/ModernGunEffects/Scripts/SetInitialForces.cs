using UnityEngine;
using System.Collections;

public class SetInitialForces : MonoBehaviour 
{
    public bool relativeForce = true;
    public float x;
    public float xDeviation; // 偏离

    public float y;
    public float yDeviation;
    public float z;
    public float zDeviation;

    public bool relativeTorque = true;
    public float torqueScale = 100;

    public float xRot;
    public float xRotDeviation;

    public float yRot;
    public float yRotDeviation;
    public float zRot;
    public float zRotDeviation;

    // Use this for initialization
    void Start()
    {
        if (relativeForce == true)
        {
            GetComponent<Rigidbody>().AddRelativeForce(Random.Range(x - xDeviation, x + xDeviation), Random.Range(y - yDeviation, y + yDeviation), Random.Range(z - zDeviation, z + zDeviation));
        }
        if (relativeForce == false)
        {
            GetComponent<Rigidbody>().AddForce(Random.Range(x - xDeviation, x + xDeviation), Random.Range(y - yDeviation, y + yDeviation), Random.Range(z - zDeviation, z + zDeviation));
        }

        if (relativeTorque == true)
        {
            GetComponent<Rigidbody>().AddRelativeTorque(Random.Range(xRot - xRotDeviation, xRot + xRotDeviation) * torqueScale, Random.Range(yRot - yRotDeviation, yRot + yRotDeviation) * torqueScale, Random.Range(zRot - zRotDeviation, zRot + zRotDeviation) * torqueScale);
        }
        if (relativeTorque == false)
        {
            GetComponent<Rigidbody>().AddTorque(Random.Range(xRot - xRotDeviation, xRot + xRotDeviation) * torqueScale, Random.Range(yRot - yRotDeviation, yRot + yRotDeviation) * torqueScale, Random.Range(zRot - zRotDeviation, zRot + zRotDeviation) * torqueScale);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
