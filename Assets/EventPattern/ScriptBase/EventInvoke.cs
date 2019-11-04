using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventInvoke : MonoBehaviour
{
    //Events Action que se suscribirán a un método de unity en la clase ActionUnityEvents
    public event Action<int> OnGolpeHit;
    public event Action<EventInvoke> OnGolpeEvent;

    //Events Action que se suscribirán a un método normal (no de unity ) en la clase ActionNormalSuscribe
    public event Action OnGolpeMessage;

    void Start()
    {
        //Esto a continuación es equivalente a lo de hasta abajo
        //if ( OnGolpeHit != null )
        //{
        //    OnGolpeHit( 1 );
        //}

        //Invoco (Si es un unityEvent) donde debo usar los eventos que tienen suscripto un método que se asigna por el inspector a través del invoke de un unityEvent
        if ( true ) {
            OnGolpeHit?.Invoke( 1 );
            OnGolpeEvent?.Invoke( this );
        }

        //Invoco (Si es un eventAction) donde debo usar los eventos que tienen suscripto un método (normal no pasado por unityEvent)
        if ( true )
        {
            OnGolpeMessage.Invoke();
        }
        
    }

}
