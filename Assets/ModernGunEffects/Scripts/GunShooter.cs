using UnityEngine;
using System.Collections;

public class GunShooter : MonoBehaviour
{
    public GameObject[] AllGuns;
    private int CurrentGunSelected = 0;

    float CurrentTime;   
    float DeltaChooseTime = 0.1f;     // 换枪的最小时间间隔
    private static GameObject CurrentGun;

	// Use this for initialization
	void Start () 
    {
        CurrentTime = Time.time;
        if (null == AllGuns){
            Debug.LogError("can not find gun");
        }
        ChangeGun();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        ChooseGun();
    }

    private void ChooseGun()
    {
        if (Input.GetKeyDown(KeyCode.Q) && Time.time - CurrentTime >= DeltaChooseTime)
        {
            CurrentGunSelected++;
            CurrentGunSelected = CurrentGunSelected % AllGuns.Length;
            ChangeGun();
            CurrentTime = Time.time;
        }
    }

    void ChangeGun()
    {
        if (null != CurrentGun){
            Destroy(CurrentGun);
        }
        CurrentGun = Instantiate(AllGuns[CurrentGunSelected], new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        CurrentGun.transform.parent = this.transform;
        CurrentGun.transform.localPosition = Vector3.zero;
        CurrentGun.transform.localEulerAngles = Vector3.zero;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 30, 500, 100), CurrentGunSelected.ToString() + " is current gun number");
    }
}

