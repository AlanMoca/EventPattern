using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class PlayerEvent : MonoBehaviour
{
    //General (Suscribe los dos métodos y los invoca al ejecutarse (UnityEVent y action) )
    public event Action OnPlayerMessage;

    //Individual 
    //Events Action que se suscribirán a un método de unity en la clase ActionUnityEvents
    public event Action OnPlayerMessageUnity;
    public event Action OnPlayerMessageAction;

    private void OnTriggerEnter( Collider other )
    {
        if ( other.gameObject.CompareTag( "Player" ) )
        {
            //General
            OnPlayerMessage?.Invoke();

            //OnPlayerMessageUnity?.Invoke();
            //OnPlayerMessageAction?.Invoke();
        }
    }

}

