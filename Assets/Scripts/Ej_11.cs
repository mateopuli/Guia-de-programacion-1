using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//11. Realizá un programa que resuelva el siguiente problema:  
//Deberá ingresarse por Inspector una fecha de compra(String en el siguiente formato:  YYYYMMDD), 
//un nombre de comprador, un nombre de producto y una cantidad y precio del producto comprado.
//Mostrá a modo de ticket, la información ingresada y el monto a pagar.Modelo de Ticket:  
//Fecha de Compra: YYYYMMDD
//Nombre del Comprador: xxxxx xxxxx
//Producto solicitado: xxxxx
//Cantidad solicitada: xx
//Precio Unitario: $xxx
//Total a Pagar: $xxxxx


public class Ej_11 : MonoBehaviour
{
    public string FechaCompra;
    public string NombreComprador;
    public string NombreProducto;
    public int CantidadProducto;
    public int PrecioProducto;
    int Total;
    // Start is called before the first frame update
    void Start()
    {
        Total = PrecioProducto * CantidadProducto;

        Debug.Log("Fecha de compra: " + FechaCompra);
        Debug.Log("Nombre del comprador: " + NombreComprador);
        Debug.Log("Producto solicitado: " + NombreProducto);
        Debug.Log("Cantidad solicitada: " + CantidadProducto);
        Debug.Log("Precio unitario: " + PrecioProducto);
        Debug.Log("Total a pagar: " + Total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
