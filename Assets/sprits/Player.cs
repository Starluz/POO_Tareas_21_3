using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public int PlayerId;
    
    public string nombre;
    public float vida;

    public float velocidad;

    BaseJugadores bdjugadores;
    void Start() 
    {
        //cambio en experimentoconarray
        // otra line de texto
        
        bdjugadores=GameObject.FindObjectOfType<BaseJugadores>();
        CargarDatos(PlayerId);

    }

    void CargarDatos(int id)
    {
        for (int i = 0; i < bdjugadores.nuevoJugador.Length; i++)
        {

            if (bdjugadores.nuevoJugador[i].PlayerId==id)
            {
                 this.nombre= bdjugadores.nuevoJugador[i].nombre;
            this.vida= bdjugadores.nuevoJugador[i].vida;
            this.velocidad= bdjugadores.nuevoJugador[i].velocidad;
            }
            
           

        }
    }
}
