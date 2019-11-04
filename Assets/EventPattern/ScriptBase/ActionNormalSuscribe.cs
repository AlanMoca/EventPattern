using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionNormalSuscribe : MonoBehaviour
{
    //Instancia de Singleton
    //Instancia con variable estática
    //Instancia como con get...?
    //Instancia con variable
    public EventInvoke OnGolpe;                             //Creo una variable que tendrá la instancia del event Action (normal) para suscribirlo en el método que usaré.

    private void OnEnable()
    {
        //Suscribo el event Action (normal) al método que está en esta clase.
        OnGolpe.OnGolpeMessage += DoSomething;
    }

    private void OnDisable()
    {
        //Desuscribo el event Action (normal) al método que está en esta clase.
        OnGolpe.OnGolpeMessage -= DoSomething;
    }

    //Método que suscribiré al evento para que se use donde se tenga que usar :V
    public void DoSomething()
    {
        Debug.Log( "Message from event" );
    }

}
