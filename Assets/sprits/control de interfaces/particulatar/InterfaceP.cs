using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceP : MonoBehaviour
{
    public Text nombreTxT;
    public Text vidaTxT;

    Player playerData;

    // Start is called before the first frame update
    void Start()
    {
        playerData=GetComponentInParent<Player>();

        StartCoroutine(AsignarDatos(1.5f));

        
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    IEnumerator AsignarDatos(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

         nombreTxT.text=playerData.nombre.ToString();

        vidaTxT.text=playerData.vida.ToString();

    }
}
