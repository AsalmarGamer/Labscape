using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{

    public string contrase�a;
    public string contrase�aFinal;
    public int contador;
    public GameObject collider;
    private bool condiAzul = true;
    private bool condiVerde = true;
    private bool condiAmarillo = true;
    private bool condiRojo = true;
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
                collider.SetActive(true);
            }
        }
    }
    public void Azul()
    {
        if(condiAzul == true)
        {
            contrase�a += "Azul ";
            Debug.Log(contrase�a);
            contador++;
            condiAzul = false;
        }     
    }
    public void Verde()
    {
        if(condiVerde == true)
        {
            contrase�a += "Verde";
            Debug.Log(contrase�a);
            contador++;
            condiVerde = false;
        }
    }
    public void Amarillo()
    {
        if(condiAmarillo == true)
        {
            contrase�a += "Amarillo";
            Debug.Log(contrase�a);
            contador++;
            condiAmarillo = false;
        }       
    }
    public void Rojo()
    {
        if(condiRojo == true)
        {
            contrase�a += "Rojo ";
            Debug.Log(contrase�a);
            contador++;
            condiRojo = false;
        }
    }
}
