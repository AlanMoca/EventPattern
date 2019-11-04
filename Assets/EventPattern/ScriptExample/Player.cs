using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public PlayerEvent _playerEvent;                                //A través de una variable llamaré a un evento que será el que se suscribirá al método que se asigne al inspecto de unity que se pasa con un invoke de unity! D:

    //Se crean los unityEvents
    public UnityPlayerMessage UnityPlayerMessage = new UnityPlayerMessage();

    private void OnEnable()
    {
        //Suscribo los eventos al método de unity
        //_playerEvent.OnPlayerMessageUnity += UnityPlayerMessage.Invoke;
        //_playerEvent.OnPlayerMessageAction += PlayerMessageAction;

        _playerEvent.OnPlayerMessage += PlayerMessageAction;                      //Se ejecutan todos los métodos que se le suscriban! :O
        _playerEvent.OnPlayerMessage += UnityPlayerMessage.Invoke;

    }

    private void OnDisable()
    {
        //Desuscribo los eventos al método de unity
        //_playerEvent.OnPlayerMessageUnity -= UnityPlayerMessage.Invoke;
        //_playerEvent.OnPlayerMessageAction -= PlayerMessageAction;

        _playerEvent.OnPlayerMessage -= PlayerMessageAction;
        _playerEvent.OnPlayerMessage -= UnityPlayerMessage.Invoke;

    }

    private void PlayerMessageAction()
    {
        Debug.Log( "Adivina quien entro por ActionEvent? :V" );
    }

    public void PlayerMessageUnity()
    {
        Debug.Log( "Adivina quien entro por UnityEvent? :V" );
    }

}

[Serializable]
public class UnityPlayerMessage : UnityEvent
{
}
