using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class barraTiempo : MonoBehaviour
{
    Vector3 escalaModificada;
    
    Vector3 escalaO;
    public bool detenerTiempo;
    private void Awake()
    {
        escalaO             = transform.localScale;
        escalaModificada    = transform.localScale;
       
    }

    private void Update() 
    {
        if(!detenerTiempo)
        {
            escalaModificada.y -= Time.deltaTime;

            if (escalaModificada.y < 0)
            {
                escalaModificada.y = 0;
                SceneManager.LoadScene("");
            }
        }

        transform.localScale = escalaModificada;
    }

    public void ResetBarra() 
    {
        transform.localScale = escalaO;

    }
}
