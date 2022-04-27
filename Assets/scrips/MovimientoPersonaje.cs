using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    private Rigidbody2D rig;
    [SerializeField] private float VelocidadPersonaje;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate()
    {
        float VelocidadInput = Input.GetAxisRaw("Horizontal");
        rig.velocity = new Vector2(VelocidadInput * VelocidadPersonaje, rig.velocity.y);
    }







}
    
 
        
    




