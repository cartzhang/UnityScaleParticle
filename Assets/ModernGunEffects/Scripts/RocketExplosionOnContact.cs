using UnityEngine;
using System.Collections;

public class RocketExplosionOnContact : MonoBehaviour 
{
    public GameObject createThis;
    [SerializeField]
    private int rocketHurt = 20;

    void OnCollisionEnter(Collision collision)
    {
        // 碰撞到子弹的话，不处理。
        if (collision.gameObject.tag == "Bullet"){
            return;
        }
        if ("Enemy" == collision.gameObject.tag)
        {
            //collision.gameObject.GetComponent<SpawnInfo>().Health -= rocketHurt;
        }
        //
        GameObject explosion = Instantiate(createThis,transform.position,transform.rotation) as GameObject;
        explosion.transform.parent = null;
        Destroy(this.gameObject.GetComponent<Rigidbody>());
        Destroy(this.gameObject,0);
    }
}
