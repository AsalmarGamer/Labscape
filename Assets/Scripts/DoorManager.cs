using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{

    public string contraseña;
    public string contraseñaFinal;
    public int contador;
    public GameObject constraint1;
    // Start is called before the first frame update
    void Start()
    {
        contraseña = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(contador == 4)
        {
            contraseñaFinal = contraseña;
            contraseña = "";
            contador = 0;
            if (contraseñaFinal == "Azul Verde Amarillo Rojo ")
            {
                constraint1.SetActive(false);
            }
        }
    }
    public void Azul()
    {
        contraseña += "Azul ";
        contador++;
    }
    public void Verde()
    {
        contraseña += "Verde";
        contador++;
    }
    public void Amarillo()
    {
        contraseña += "Amarillo";
        contador++;
    }
    public void Rojo()
    {
        contraseña += "Rojo ";
        contador++;
    }
}
