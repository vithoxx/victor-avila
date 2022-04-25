using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform gun;
    public SpriteRenderer gunSR;
    public int speedball;
    Vector3 targetRotation;

    public GameObject Ball;
    Vector3 FinalTarget;

    private void Update()
    {
        targetRotation = Input.mousePosition = Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(targetRotation.y, targetRotation.x) = Mathf.Rad2Deg;
        gun.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        if (angle > 90 || angle < -90)
            gunSR.flipY = true;
        else
            gunSR.flipY = false;

        if (Input.GetKeyDown(KeyCode.Mouse0))
            Shoot();
    }
    void Shoot()
    {
        var Ball = Instantiate(Ball, gun.position, transform.rotation, transform.parent);
        targetRotation.z = 0;
        FinalTarget = (targetRotation - transform.position).normalized;
        Ball.GetConponent<Rigidbody2D>().addforce(FinalTarget * speedball, ForceMode2D.Impulse);



    }





    



