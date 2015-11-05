using UnityEngine;
using System.Collections;

public class MoveThis : MonoBehaviour 
{
    public float translationSpeedX = 0;
    public float translationSpeedY = 1;
    public float translationSpeedZ = 0;
    public bool local = true;

    public bool isFollowTarget = true;
    public float moveSpeed = 5; //move speed
    public float rotationSpeed = 5; //speed of turning

    private RaycastHit hit;
    private Transform TargetTransform = null;

    void Start()
    {
        if (true == isFollowTarget && null != Camera.main)
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Enemy")
                {
                    GameObject TmpObj = hit.collider.gameObject;
                    // 射中目标点位置。
                    TargetTransform = TmpObj.transform.FindChild("HitPoint");
                    if (null == TargetTransform){
                        TargetTransform = TmpObj.transform;
                    }
                }
            }
        }  
    }
	// Update is called once per frame
	void Update () 
    {
        if (true == local)
        {  
            // 跟踪对象消失，就直线飞行。
            if(null != TargetTransform)
            {
                FollowGameObject(TargetTransform);
            }
            else
            {
                this.transform.Translate(new Vector3(translationSpeedX, translationSpeedY, translationSpeedZ) * Time.deltaTime);
            }
        }
        //
        if (false == local)
        {
            this.transform.Translate(new Vector3(translationSpeedX, translationSpeedY, translationSpeedZ) * Time.deltaTime,Space.World);
        }            
	}

    /// <summary>
    /// 开始跟踪对象
    /// </summary>
    /// <param name="Targetobj"></param>
    void FollowGameObject(Transform Targetobj)
    {
        Vector3 mytransform = Targetobj.position;
        //rotate to look at the player
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(mytransform - transform.position),
                                                rotationSpeed * Time.deltaTime);
        //move towards the player
        transform.position += transform.forward * Time.deltaTime * moveSpeed;
    }
}
