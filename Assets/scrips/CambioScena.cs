using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScena : MonoBehaviour
{
    public int numeroEscena;

    public void cambiarEscena() 
    {

        SceneManager.LoadScene(numeroEscena);
    
    }


    public void Salir()
    {

        Application.Quit();
        Debug.Log("Aplicacion Cerrada");
    }

    public void ReiniciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
