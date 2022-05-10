using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    [SerializeField]
    Transform[] waypoints;

    [SerializeField]
    float moveSpeed = 2f;

    int waypointIndex = 0;

    private void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
        
        void Update () 
        {
            move();
        }

        void move()
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);
        }

        if (transform.position == waypoints[waypointIndex].transform.position) { waypointIndex += 1; 
        }
        if (waypointIndex == waypoints.Length)
            waypointIndex = 0;

    }
}
