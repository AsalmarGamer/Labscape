using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    [SerializeField] AudioSource boton;
    [SerializeField] AudioSource mal;
    [SerializeField] AudioSource bien;
    [SerializeField] AudioSource shutdown;
    [SerializeField] AudioSource GeneratorSfx;

    [SerializeField] Material connectedMat;
    [SerializeField] Renderer panelMano;

    [SerializeField] GameObject coliderPuerta;
    [SerializeField] GameObject collider;
    [SerializeField] GameObject[] puzzle2items;

    [SerializeField] GameObject Correcto;
    [SerializeField] GameObject Incorrecto;

    public string contraseña;
    public string contraseñaFinal;

    public int contador;

    private bool condiAzul = true;
    private bool condiVerde = true;
    private bool condiAmarillo = true;
    private bool condiRojo = true;
    private bool connectedWire1 = false;
    private bool connectedWire2 = false;
    private bool dial1 = false;
    private bool dial2 = false;
    private bool dial3 = false;
    private bool dial4 = false;

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
                Correcto.SetActive(true);
                bien.Play();
            }
            else
            {
                Incorrecto.SetActive(true);
                Invoke("ActivarBotones", 2f);
                mal.Play();
            }
        }
        if(connectedWire1 == true & connectedWire2 == true)
        {
            coliderPuerta.SetActive(true);
            bien.Play();
            panelMano.sharedMaterial = connectedMat;
        }
        if(dial1 == true & dial2 == true & dial3 == true & dial4 == true )
        {
            puzzle2items[0].SetActive(true);
            puzzle2items[1].SetActive(true);
            puzzle2items[2].SetActive(true);
            puzzle2items[3].SetActive(true);
            puzzle2items[4].SetActive(true);
            puzzle2items[5].SetActive(false);
            puzzle2items[6].SetActive(true);
            puzzle2items[7].SetActive(true);
            puzzle2items[8].SetActive(false);
            puzzle2items[9].SetActive(false);
            GeneratorSfx.Play();
            dial1 = false;
            dial2 = false;
            dial3 = false;
            dial4 = false;
        }
    }
    private void ActivarBotones()
    {
        Incorrecto.SetActive(false);
        condiAzul = true;
        condiVerde = true;
        condiAmarillo = true;
        condiRojo = true;
    }
    public void TargetDial1()
    {
        dial1 = true;
    }
    public void TargetDial1NO()
    {
        dial1 = false;
    }
    public void TargetDial2()
    {
        dial2 = true;
    }
    public void TargetDial2NO()
    {
        dial2 = false;
    }
    public void TargetDial3()
    {
        dial3 = true;
    }
    public void TargetDial3NO()
    {
        dial3 = false;
    }
    public void TargetDial4()
    {
        dial4 = true;
    }
    public void TargetDial4NO()
    {
        dial4 = false;
    }
    public void Wire1()
    {
        connectedWire1 = true;
    }
    public void Wire2()
    {
        connectedWire2 = true;
    }
    public void Azul()
    {
        if(condiAzul == true)
        {
            contraseña += "Azul ";
            Debug.Log(contraseña);
            contador++;
            condiAzul = false;
            boton.Play();
        }     
    }
    public void Verde()
    {
        if(condiVerde == true)
        {
            contraseña += "Verde ";
            Debug.Log(contraseña);
            contador++;
            condiVerde = false;
            boton.Play();
        }
    }
    public void Amarillo()
    {
        if(condiAmarillo == true)
        {
            contraseña += "Amarillo ";
            Debug.Log(contraseña);
            contador++;
            condiAmarillo = false;
            boton.Play();
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
            boton.Play();
        }
    }
    public void Shutdownsound()
    {
        shutdown.Play();
    }

}
