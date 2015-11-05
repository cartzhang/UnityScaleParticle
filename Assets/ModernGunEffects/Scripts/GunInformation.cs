using UnityEngine;
using System.Collections;

public class GunInformation : MonoBehaviour
{
    private Vector3 MousePos;
    private Quaternion MouseRotate;
    private RaycastHit hit;

    public GameObject muzzleEffectPlace;
    public GameObject cartridgeEffectPlace;

    public GameObject muzzleEffect;       // 枪口特效
    public GameObject cartridgeEffect;    // 弹壳
    //public GameObject impactEffect;      // 贴花特效

    public GameObject BulletFirePoint;
    public GameObject Bullet;

    float CurrentTime;   
    float LifeTime = 0.1f; // 发射子弹的最小时间间隔
    
	// Use this for initialization
	void Start () 
    {
        CurrentTime = Time.time;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        //bool IsNeedImpactEffect = false;
        //if(null != Camera.main)
        //{
        //    //var ray = Camera.main.ScreenPointToRay(Input.mousePosition);   // 鼠标作为Impact 贴图的位置点。
        //    var ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 4.0f, Screen.height / 2.0f, 0.0f));     // 屏幕中心为Impact 贴图位置点
        //    // 鼠标不用来指向枪的位置朝向。
        //    //transform.LookAt(ray.GetPoint(10.0f));
        //    if (Physics.Raycast(ray, out hit))
        //    {  //ray hit position
        //        if (hit.collider.tag != "Bullet")
        //        {
        //            MousePos = hit.point;
        //            MouseRotate = hit.collider.gameObject.transform.rotation;
        //        }
        //        IsNeedImpactEffect = true;
        //    }
        //}

        if (Input.GetMouseButton(0)&& Time.time - CurrentTime >= LifeTime)// 
        {   
            //on mouse click
            if (null != muzzleEffect)
            {
                //GameObject effect = 
                Instantiate(muzzleEffect, muzzleEffectPlace.transform.position, muzzleEffectPlace.transform.rotation);
                        //as GameObject;
                //effect.transform.parent = muzzleEffectPlace.transform;
                Instantiate(cartridgeEffect, cartridgeEffectPlace.transform.position, cartridgeEffectPlace.transform.rotation);
            }
            //if (true == IsNeedImpactEffect)
            //{
            //    GameObject TmpimpactEffct = Instantiate(impactEffect, MousePos, MouseRotate) as GameObject;
            //    TmpimpactEffct.transform.LookAt(Camera.main.transform.position);
            //}
            //
            Fire(BulletFirePoint.transform);
            CurrentTime = Time.time;
        }
    }

    void Fire(Transform Tsf)
    {
        if (null != Tsf && null != Bullet)
        {
            Instantiate(Bullet, Tsf.position, Tsf.rotation);
        }
        else 
        {
            Debug.Log("can not fire now ");
        }
    }
    
}

