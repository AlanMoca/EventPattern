using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class ActionUnityEvents : MonoBehaviour
{

    //Instancia de Singleton
    //Instancia con variable estática
    //Instancia como con get...?
    //Instancia con variable
    public EventInvoke OnGolpe;                                                     //A través de una variable llamaré a un evento que será el que se suscribirá al método que se asigne al inspecto de unity que se pasa con un invoke de unity! D:
    public ActionNormalSuscribe OnGolpeMessage;                                     //Pasaré el método que se agregará al listener con parametro void

    //Se crean los unityEvents
    public UnityGolpeHit OnGolpeHit = new UnityGolpeHit();
    public UnityGolpeEvent OnGolpeEvent = new UnityGolpeEvent();

    //Ejemplo de Listener con un unityEvent
    public UnityGolpeMessage UnityGolpeMessage = new UnityGolpeMessage();


    private void OnEnable()
    {
        //Suscribo los eventos al método de unity
        OnGolpe.OnGolpeHit += OnGolpeHit.Invoke;
        OnGolpe.OnGolpeEvent += OnGolpeEvent.Invoke;
    }

    private void OnDisable()
    {
        //Desuscribo los eventos al método de unity
        OnGolpe.OnGolpeHit -= OnGolpeHit.Invoke;
        OnGolpe.OnGolpeEvent -= OnGolpeEvent.Invoke;
    }

    //Ejemplo de listener con unity Event
    private void AddUnityListener()
    {
        UnityGolpeMessage.AddListener( () => OnGolpeMessage.DoSomething() );
    }

}

[SerializeField]
public class UnityGolpeMessage : UnityEvent
{
}

[SerializeField]
public class UnityGolpeHit : UnityEvent<int>
{
}

[SerializeField]
public class UnityGolpeEvent : UnityEvent<EventInvoke>
{
}
