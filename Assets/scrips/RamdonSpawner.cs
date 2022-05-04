using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamdonSpawner : MonoBehaviour
{
    
    public GameObject enemy;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate;
    float nextSpawn = 0.0f;
    public float tiempomin, tiempomax;
    // Start is called before the first frame update
    void Start()
    {
        nextSpawn = Random.Range(tiempomin, tiempomax);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            spawnRate = Random.Range(tiempomin,tiempomax);
            nextSpawn = Time.time + spawnRate;
           // randX = Random.Range(minX, maxX);
           // whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy,transform.position,enemy.transform.rotation );
        }
    }
}

