using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{

    public int hp;
    public float aireDaño;
    public void Daño()
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

    public void QuitarVida()
    {
        ElGlobo.aire -= aireDaño;
        gamemanager.manager.QuitarVida();

        GameObject Obj = GameObject.Find("ElGlobo");
        ElGlobo Globo = Obj.GetComponent<ElGlobo>();
        Globo.lives--;
    }


}
