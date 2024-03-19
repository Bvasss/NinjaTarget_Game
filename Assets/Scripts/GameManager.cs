using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int puntos;
   
    public Text textoPuntos;


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

    public void CargarEscenaPrincipal()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void CargarPausa()
    {
        SceneManager.LoadScene("Pausa");
    }

}