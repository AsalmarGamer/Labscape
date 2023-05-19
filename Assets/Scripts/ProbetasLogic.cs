using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbetasLogic : MonoBehaviour
{
    [SerializeField] GameObject prefabMorado;
    [SerializeField] GameObject prefabNaranja;
    [SerializeField] GameObject prefabRosado;
    [SerializeField] GameObject prefabAzulClaro;
    [SerializeField] GameObject prefabVerde;
    [SerializeField] GameObject prefabMalo;

    [SerializeField] Vector3 spawnPosition;

    [SerializeField] AudioSource sonidoLlenado;

    private bool condiRojo = false;
    private bool condiAzul = false;
    private bool condiMorado = false;
    private bool condiAmarillo = false;
    private bool condiRosado = false;
    private bool condiNaranja = false;
    private bool condiAzulClaro = false;

    private int contador = 0;


    void Update()
    {
        if(contador == 2)
        {
            contador = 0;
            sonidoLlenado.Play();
            if (condiAzul == true & condiRojo == true)
            {
                Invoke("SpawnMorado",1f);        
            }
            else if (condiAmarillo == true & condiRojo == true)
            {
                Invoke("SpawnNaranja", 1f);
            }
            else if (condiAmarillo == true & condiMorado == true)
            {
                Invoke("SpawnRosado", 1f);
            }
            else if(condiNaranja == true & condiRosado == true)
            {
                Invoke("SpawnAzulClaro", 1f);
            }
            else if(condiAzulClaro == true & condiAzul == true)
            {
                Invoke("SpawnVerde", 1f);
            }
            condiRojo = false;
            condiAzul = false;
            condiMorado = false;
            condiAmarillo = false;
            condiRosado = false;
            condiNaranja = false;
            condiAzulClaro = false;
        }
    }
    private void SpawnMorado()
    {
        prefabMorado.transform.position = spawnPosition;
    }
    private void SpawnNaranja()
    {
        prefabNaranja.transform.position = spawnPosition;
    }
    private void SpawnRosado()
    {
        prefabRosado.transform.position = spawnPosition;
    }
    private void SpawnAzulClaro()
    {
        prefabAzulClaro.transform.position = spawnPosition;
    }
    private void SpawnVerde()
    {
        prefabVerde.transform.position = spawnPosition;
    }
    private void SpawnMalo()
    {
        Instantiate(prefabMalo, spawnPosition, Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("eNTRASTES");
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
        if (other.gameObject.tag == "Morado")
        {
            condiMorado = true;
            contador++;
        }
        if (other.gameObject.tag == "Amarillo")
        {
            condiAmarillo = true;
            contador++;
        }
        if (other.gameObject.tag == "Naranja")
        {
            condiNaranja = true;
            contador++;
        }
        if (other.gameObject.tag == "Rosado")
        {
            condiRosado = true;
            contador++;
        }
        if (other.gameObject.tag == "AzulClaro")
        {
            condiAzulClaro = true;
            contador++;
        }

    }
}
