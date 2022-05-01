using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarGlobo : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private float speed = 1.5f;
   
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
        transform.up = Player.transform.position - transform.position;
    }
}
