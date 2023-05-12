using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{

    public string contraseña;
    public string contraseñaFinal;
    public int contador;
    public GameObject collider;
    private bool condiAzul = true;
    private bool condiVerde = true;
    private bool condiAmarillo = true;
    private bool condiRojo = true;
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
                collider.SetActive(true);
            }
        }
    }
    public void Azul()
    {
        if(condiAzul == true)
        {
            contraseña += "Azul ";
            Debug.Log(contraseña);
            contador++;
            condiAzul = false;
        }     
    }
    public void Verde()
    {
        if(condiVerde == true)
        {
            contraseña += "Verde";
            Debug.Log(contraseña);
            contador++;
            condiVerde = false;
        }
    }
    public void Amarillo()
    {
        if(condiAmarillo == true)
        {
            contraseña += "Amarillo";
            Debug.Log(contraseña);
            contador++;
            condiAmarillo = false;
        }       
    }
    public void Rojo()
    {
        if(condiRojo == true)
        {
            contraseña += "Rojo ";
            Debug.Log(contraseña);
            contador++;
            condiRojo = false;
        }
    }
}
