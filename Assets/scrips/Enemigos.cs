using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{

    public int hp;
    public float aireDa�o;
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

    public void QuitarVida()
    {
        ElGlobo.aire -= aireDa�o;
        gamemanager.manager.QuitarVida();

        GameObject Obj = GameObject.Find("ElGlobo");
        ElGlobo Globo = Obj.GetComponent<ElGlobo>();
        Globo.lives--;
    }


}
