using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{

    public string contraseņa;
    public string contraseņaFinal;
    public int contador;
    public GameObject constraint1;
    // Start is called before the first frame update
    void Start()
    {
        contraseņa = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(contador == 4)
        {
            contraseņaFinal = contraseņa;
            contraseņa = "";
            contador = 0;
            if (contraseņaFinal == "Azul Verde Amarillo Rojo ")
            {
                constraint1.SetActive(false);
            }
        }
    }
    public void Azul()
    {
        contraseņa += "Azul ";
        contador++;
    }
    public void Verde()
    {
        contraseņa += "Verde";
        contador++;
    }
    public void Amarillo()
    {
        contraseņa += "Amarillo";
        contador++;
    }
    public void Rojo()
    {
        contraseņa += "Rojo ";
        contador++;
    }
}
