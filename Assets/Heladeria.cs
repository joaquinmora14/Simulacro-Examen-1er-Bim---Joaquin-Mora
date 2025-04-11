using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    public string gustoDeHelado;
    public int cantidadDeHelado;
    float precioPorGramo = 1.25f;
    int cantidadMinima = 250;
    int cantidadMaxima = 3000;
    float precioFinal;
    float descuentoFru = 0.9F;

    // Start is called before the first frame update
    void Start()
    {
        if (cantidadDeHelado < cantidadMinima || cantidadDeHelado > cantidadMaxima)
        {
            Debug.Log("La cantidad ingresada no es valida, el minimo es 250 y el maximo es 3000");
            return;
        }
        else if (gustoDeHelado != "FRU" && gustoDeHelado != "CHO" && gustoDeHelado != "DDL")
        { 
        Debug.Log("Codigo no valido");
        return;
        }

        if (gustoDeHelado == "DDL" || gustoDeHelado == "CHO")
        {
            precioFinal = cantidadDeHelado * precioPorGramo;
            Debug.Log("El precio final es " + precioFinal);
        }
        else if(gustoDeHelado == "FRU")
        {
            precioFinal = cantidadDeHelado * precioPorGramo;
            precioFinal *= descuentoFru;
            Debug.Log("El precio final es " + precioFinal);
        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
