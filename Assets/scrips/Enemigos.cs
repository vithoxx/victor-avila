using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{

    public int hp;

    public void Da�o()
    {
        hp--;
        
        if(hp < 1)
        {
            gameObject.SetActive(false);
        }
    }

    public void DispararArma()
    {
        gamemanager.manager.DispararArma();
    }

}
