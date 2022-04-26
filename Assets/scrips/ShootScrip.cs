using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScrip : MonoBehaviour
{
    public Transform Gun;

    Vector2 direction;

    public GameObject Bullet;

    public float BulletSpeed;

    public Transform ShootPoint;

    private void Update()
    {
        Vector2 mausePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mausePos - (Vector2)Gun.position;
        FaceMouse();

        if (Input.GetMouseButtonDown(0))
        {

           shoot()
        
        }

    }
    void FaceMouse()
    {

        Gun.transform.right = direction;

    }

    void shoot()
    {
        GameObject BulletIns = Instantiate(Bullet, ShootPoint.position, ShootPoint.rotation);
        BulletIns = GetComponent<Rigidbody2D>().AddForce(BulletIns.transform.right * BulletSpeed);

    
    }


}
     

    