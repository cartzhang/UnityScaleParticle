using UnityEngine;
using System.Collections;

public class PrefabGenerator : MonoBehaviour 
{
    public GameObject[] createThis;
    private float rndNr;
    public int thisManyTimes;
    public float overThisTime;

    public float xWidth;
    public float yWidth;
    public float zWidth;

    public float xRotMax;
    public float yRotMax = 180f;
    public float zRotMax;

    public bool detachToWorld = false;

    private float xCur;
    private float yCur;
    private float zCur;

    private float xRotCur;
    private float yRotCur;
    private float zRotCur;

    private float timeCounter;
    private float effectCounter;

    private float trigger;
	// Use this for initialization
	void Start () 
    {
        if (thisManyTimes < 1.0f)
        {
            thisManyTimes = 1;
        }
        trigger = overThisTime / thisManyTimes;
	}
	
	// Update is called once per frame
	void Update ()
    {
        timeCounter += Time.deltaTime;
        if (timeCounter > trigger && effectCounter <= thisManyTimes)
        {
            rndNr = Mathf.Floor(Random.value * createThis.Length);
            xCur = (Random.value * xWidth) - (xWidth * 0.5f);  // decide an actual place
            yCur = (Random.value * yWidth) - (yWidth * 0.5f);
            zCur = (Random.value * zWidth) - (zWidth * 0.5f);

            xRotCur = transform.localRotation.x + (Random.value * xRotMax * 2) - (xRotMax);  // decide rotation
            yRotCur = transform.localRotation.y + (Random.value * yRotMax * 2) - (yRotMax);
            zRotCur = transform.localRotation.z + (Random.value * zRotMax * 2) - (zRotMax);

            GameObject justCreated = Instantiate(createThis[(int)rndNr], transform.position, transform.rotation) as GameObject;  //create the prefab
            justCreated.transform.Rotate(xRotCur, yRotCur, zRotCur);
            justCreated.transform.Translate(xCur, yCur, zCur);

            if (detachToWorld == true) justCreated.transform.parent = null;
            timeCounter -= trigger;  //administration :p
            effectCounter += 1;
        }
	}
}
