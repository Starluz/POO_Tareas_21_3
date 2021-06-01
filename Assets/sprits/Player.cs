using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public string nombre;

    public int PlayerId;

    public float vida;

    public float velocidad;

    BaseJugadores bdjugadores;
    private void Start() 
    {
        bdjugadores=GameObject.FindObjectOfType<BaseJugadores>();

        
    }

}
