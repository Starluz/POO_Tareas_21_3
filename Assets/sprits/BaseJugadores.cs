using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseJugadores : MonoBehaviour
{
       public ConstructorPlayer[] nuevoJugador;
    // Start is called before the first frame update
    void Start()
    {
        nuevoJugador[0]=new ConstructorPlayer(1,"goku",10,5);
        nuevoJugador[1]= new ConstructorPlayer(2,"Kobaski",10,5);
    
    }

   
}
