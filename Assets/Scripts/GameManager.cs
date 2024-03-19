using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int puntos;
    public int intentos;
    public int altitud;
    public int fuerza;  
    public Text textoPuntos;
    public Text textoI;
    public Text textoA;
    public Text textoF;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sumarPuntos(int puntaje){
        puntos = puntos + puntaje;
        textoPuntos.text = puntos.ToString();
        
    }
    public void sumarintentos(int totalThrows){
        intentos = intentos + totalThrows;
        textoI.text = intentos.ToString();
        
    }
    public void sumaraltitud(int throwUpwardForce){
        altitud = altitud + throwUpwardForce;
        textoA.text = altitud.ToString();
        
    }
    public void sumarfuerza(int throwForce){
        intentos = intentos + throwForce;
        textoF.text = throwForce.ToString();
        
    }
}