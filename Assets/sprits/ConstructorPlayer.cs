using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ConstructorPlayer 
{
    public int PlayerId;

    public string nombre;
    
    public float vida;
    public float velocidad;

    private Transform posicionActual;

    private int daño;
    
        //metodo Constructor
    public ConstructorPlayer(int id, string n, float vida, float vel)
    {
        this.PlayerId= id;
        this.nombre= n;
        this.vida= vida;
        this.velocidad= vel;
    }
    
}
