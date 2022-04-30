using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElGlobo : MonoBehaviour
{
    public static float aire = 15;
    public Transform globoTransform;
    public float velocidadResta;

    public bool elGloboSeInflo;


    private void Awake()
    {
        aire = 1;
    }
    private void Update()
    {

        ChequearAire();


        if(elGloboSeInflo == false)
        {
            aire = aire - Time.deltaTime * velocidadResta;
            aire = Mathf.Clamp(aire, 1, 15);
            Vector3 nuevaEscalaGlobo = Vector3.one;
            globoTransform.localScale = Vector3.Lerp(globoTransform.localScale, nuevaEscalaGlobo * aire, Time.deltaTime * 5);
        }


    }


    void ChequearAire()
    {
        // chequear si el globo esta totalmente inflado
        if (aire >= 15)
        {
            elGloboSeInflo = true;
            gamemanager.manager.Wingame();
        }
        else
        {
            elGloboSeInflo = false;
        }
    }

}
