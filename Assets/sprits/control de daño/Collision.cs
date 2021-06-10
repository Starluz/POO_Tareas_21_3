using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    
    public float daño;

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "player")
        {

            other.gameObject.GetComponent<DañoJugador>().damage(50);

        }
        // termina funcion
        
    }
}
