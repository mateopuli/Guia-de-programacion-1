using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//13. Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera:  
//• Si trabaja 40 horas o menos se le paga $16 por hora(crear una constante para almacenar el 16)
//• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20  por cada 
//hora extra. (crear una constante para almacenar el 20)
//Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla el salario correspondiente.

public class Ej_13 : MonoBehaviour
{
    public int horas;
    int Salario;
    int HorasExtra;
    int PagaExtra;
    // Start is called before the first frame update
    void Start()
    {
        if (horas <= 40)
        {
            Salario = horas * 16;
            Debug.Log("Usted a trabajado " + horas + " y el salario que le corresponde es " + Salario + ".");
        }
        else if (horas > 40)
        {
            Salario = 40 * 16; // Le ponemos 40 por 16 ya que las horas que trabajo despues de las 40 entran en HorasExtra (y lo que gano en PagaExtra), y de esa forma se suma lo ganado en las 40 horas mas lo ganado en las horas extra.
            HorasExtra = horas - 40; // ej: trabajo 56 horas, entonces 56 - 40 es 16, por lo que trabajo 16 horas extra.
            PagaExtra = HorasExtra * 20; // A partir de saber cuantas horas extra trabajo, las multiplicamos por 20 para asi saber cuanto gano trabajando en esas horas extra.
            Salario = Salario + PagaExtra;
            Debug.Log("Usted a trabajado " + horas + " y el salario que le corresponde es " + Salario + ".");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
