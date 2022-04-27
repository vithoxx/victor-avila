using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirarMouse : MonoBehaviour
{
    public GameObject spriteArmaDe, spriteArmaIz;

    private void Start()
    {
        spriteArmaDe.SetActive(false);
        spriteArmaIz.SetActive(false);
    }
    private void Update()
    {
        Vector3 posMause = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 direccion = Input.mousePosition - posMause;
        float angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angulo, Vector3.forward);

        CorrecionDirecion();
    }

    void CorrecionDirecion()
    {
        Vector3 posMetralleta = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 mousePos = Input.mousePosition;

        if(posMetralleta.x < mousePos.x)
        {
            spriteArmaDe.SetActive(true);
            spriteArmaIz.SetActive(false);
        }
        else
        {
            spriteArmaDe.SetActive(false);
            spriteArmaIz.SetActive(true);
        }


    }
}
