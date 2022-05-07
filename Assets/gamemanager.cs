using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public Animator animatorPlayer;
    public Animator animDisparo1, animDisparo2;
    public static gamemanager manager;
    public GameObject personajeAfuera;
    public GameObject personajeAdentro;
    public GameObject mensajeVictoria;
  
    public GameObject quitarvida;
    public int hp;

    private void Awake()
    {
        manager = this;
    }

    

    public void Wingame()
    {
        // se cumplio la condicion de victoria
        // el globo sale volando
        // se activa algun mensaje de victoria

        personajeAfuera.SetActive(false);
        personajeAdentro.SetActive(true);
        animatorPlayer.Play("GloboSeVa");
        mensajeVictoria.SetActive(true);

    }

    public void Resetgame()
    {
       
    }

    public void DispararArma()
    {
        animDisparo1.Play("disparo");
        animDisparo2.Play("disparo");
    }

    public void QuitarVida()
    {
        hp--;

        if(hp < 1)
        {
            //Gameover
        }
    }

}
