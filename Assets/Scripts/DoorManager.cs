using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{

    public string contrase�a;
    public string contrase�aFinal;
    public int contador;
    public GameObject constraint1;
    // Start is called before the first frame update
    void Start()
    {
        contrase�a = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(contador == 4)
        {
            contrase�aFinal = contrase�a;
            contrase�a = "";
            contador = 0;
            if (contrase�aFinal == "Azul Verde Amarillo Rojo ")
            {
                constraint1.SetActive(false);
            }
        }
    }
    public void Azul()
    {
        contrase�a += "Azul ";
        contador++;
    }
    public void Verde()
    {
        contrase�a += "Verde";
        contador++;
    }
    public void Amarillo()
    {
        contrase�a += "Amarillo";
        contador++;
    }
    public void Rojo()
    {
        contrase�a += "Rojo ";
        contador++;
    }
}
