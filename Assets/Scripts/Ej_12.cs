using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//12. En un casino de juegos se desea mostrar los mensajes respectivos por el puntaje 
//obtenido en el lanzamiento de tres dados de un cliente, de acuerdo a los siguientes  resultados:  
//• Si los tres dados son seis, mostrar el mensaje “Excelente” 
//• Si dos dados son seis, mostrar el mensaje “Muy bien”  
//• Si un dado es seis, mostrar el mensaje “Regular”  
//• Si ningún dado se obtiene seis, mostrar el mensaje “Insuficiente” 


public class Ej_12 : MonoBehaviour
{
    public int dado1;
    public int dado2;
    public int dado3;

    // Start is called before the first frame update
    void Start()
    {
        int cantseis = 0;
        if (dado1 == 6)
        {
            cantseis++;
        }
        if (dado2 == 6)
        {
            cantseis++;
        }
        if (dado3 == 6)
        {
            cantseis++;
        }
        switch (cantseis)
        {
            case 3:
                Debug.Log("Excelente");
                break;
            case 2:
                Debug.Log("Muy Bien");
                break;
            case 1:
                Debug.Log("Regular");
                break;
            case 0:
                Debug.Log("Insuficiente");
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
