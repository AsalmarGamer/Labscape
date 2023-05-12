using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{

    public string contraseņa;
    public string contraseņaFinal;
    public int contador;
    public GameObject collider;
    private bool condiAzul = true;
    private bool condiVerde = true;
    private bool condiAmarillo = true;
    private bool condiRojo = true;
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
                collider.SetActive(true);
            }
        }
    }
    public void Azul()
    {
        if(condiAzul == true)
        {
            contraseņa += "Azul ";
            Debug.Log(contraseņa);
            contador++;
            condiAzul = false;
        }     
    }
    public void Verde()
    {
        if(condiVerde == true)
        {
            contraseņa += "Verde";
            Debug.Log(contraseņa);
            contador++;
            condiVerde = false;
        }
    }
    public void Amarillo()
    {
        if(condiAmarillo == true)
        {
            contraseņa += "Amarillo";
            Debug.Log(contraseņa);
            contador++;
            condiAmarillo = false;
        }       
    }
    public void Rojo()
    {
        if(condiRojo == true)
        {
            contraseņa += "Rojo ";
            Debug.Log(contraseņa);
            contador++;
            condiRojo = false;
        }
    }
}
