
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseJugadores : MonoBehaviour
{
       public ConstructorPlayer[] nuevoJugador;
    // Start is called before the first frame update
    void Awake()
    {
        nuevoJugador= new ConstructorPlayer[4];
        nuevoJugador[0]=new ConstructorPlayer(1,"goku",10,5);
        nuevoJugador[1]= new ConstructorPlayer(2,"Kobaski",5,7);
        nuevoJugador[2]= new ConstructorPlayer(3,"Rico",50,6);
        nuevoJugador[3]= new ConstructorPlayer(3,"skipper",10,4);

       
    
    }

   
}
