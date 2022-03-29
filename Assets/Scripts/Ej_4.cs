using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//4.. Realizá un programa que permita ingresar dos números enteros num1 y num2 por Inspector. 
//Luego, mostrar el resultado de la suma entre ambos al ejecutar la escena utilizando el 
//siguiente formato: “La  suma entre “ + num1 + “ y “ + num2 + “ da como resultado “ + num1 + num2. 

public class Ej_4 : MonoBehaviour
{
    // Start is called before the first frame update
    public int num1;
    public int num2;
    void Start()
    {
        int suma = num1 + num2;
        Debug.Log("La suma entre "+ num1 + " y "+ num2 + " da como resultado " + suma);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
