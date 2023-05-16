using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbetasLogic : MonoBehaviour
{
    [SerializeField] GameObject prefabMorado;
    [SerializeField] GameObject prefabMalo;
    [SerializeField] Vector3 spawnPosition;

    private bool condiRojo = false;
    private bool condiAzul = false;

    private int contador = 0;

    void Update()
    {
        if(contador == 2)
        {
            contador = 0;
            if (condiAzul == true & condiRojo == true)
            {
                Invoke("SpawnMorado",1f);        
                //Poner un audio
            }
            else
            {
                Invoke("SpawnMalo", 1f);
            }
            condiRojo = false;
            condiAzul = false;
        }
    }
    private void SpawnMorado()
    {
        Instantiate(prefabMorado, spawnPosition, Quaternion.identity);
    }
    private void SpawnMalo()
    {
        Instantiate(prefabMalo, spawnPosition, Quaternion.identity);
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Rojo")
        {
            condiRojo= true;
            contador++;
        }
        if (collision.gameObject.tag == "Azul")
        {
            condiAzul = true;
            contador++;
        }
    }*/
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entrastes");
        if (other.gameObject.tag == "Rojo")
        {
            condiRojo = true;
            contador++;
        }
        if (other.gameObject.tag == "Azul")
        {
            condiAzul = true;
            contador++;
        }
    }
}
