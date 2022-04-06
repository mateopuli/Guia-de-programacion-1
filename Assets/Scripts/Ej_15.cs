using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//15. Existen dos reglas que identifican dos conjuntos de valores: 
//- El número es de un solo dígito.
//- El número es impar.
//A partir de estas reglas, creá un algoritmo que asigne a las variables booleanas estaEnA, 
//estaEnB, estaEnAmbos y noEstaEnNinguno el valor verdadero o falso, según corresponda, 
//para indicar si el valor ingresado pertenece al primer conjunto, al segundo, a ambos o a  ninguno, 
//respectivamente.Definí un lote de prueba de varios números y probá el algoritmo, escribiendo los resultados.

public class Ej_15 : MonoBehaviour
{
    public int num1;
    // Start is called before the first frame update
    void Start()
    {
        bool estaEnA = false;
        bool estaEnB = false;
        bool estaEnAmbas = false;
        bool noEstaEnNinguno = false;

        if (num1 % 2 > 0 || num1 < 10 && num1 > 0)
        {
            estaEnAmbas = true;
            Debug.Log("El numero ingresado contiene un solo digito y es impar.");
        }
        else if (num1 % 2 > 0)
        {
            estaEnB = true;
            Debug.Log("El numero ingresado es impar.");
        }
        else if (num1 < 10 && num1 > 0)
        {
            estaEnA = true;
            Debug.Log("El numero ingresado contiene un solo digito.");
        }
        else
        {
            noEstaEnNinguno = true;
            Debug.Log("El numero ingresado no es impar y contiene mas de un digito.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
