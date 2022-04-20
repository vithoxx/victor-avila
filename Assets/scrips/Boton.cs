using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{

    public float cantidadAire;
    public Animator animator;
    public string nombreDeAnimacion;
    private void OnMouseDown()
    {
        animator.Play(nombreDeAnimacion);
        ElGlobo.aire += cantidadAire;
    }
}
