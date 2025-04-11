using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    public string gustoDeHelado;
    public float cantidadDeHelado;
    float precioPorGramo = 1.25f;
    int cantidadMinima = 250;
    int cantidadMaxima = 3000;
    float precioFinal;
    float descuentoFru = 0.9;
    float precioFinalDescuento;
    // Start is called before the first frame update
    void Start()
    {
        if (gustoDeHelado = "DDL" ||gustoDeHelado = "CHO") ;
        precioFinal = cantidadDeHelado * precioPorGramo;
        Debug.Log("El precio final es " + precioFinal);

        if (cantidadDeHelado < cantidadMinima || cantidadDeHelado > cantidadMaxima) ;
        Debug.log("La cantidad ingresada no es valida, el minimo es 250 y el maximo es 3000");

        if (gustoDeHelado = "FRU") ;
        precioFinal = cantidadDeHelado * precioPorGramo;
        precioFinalDescuento = precioFinal * descuentoFru;
        //precioFinal* descuentoFru = precioFinalDescuento;

        Debug.Log("El precio final es " + precioFinalDescuento);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
