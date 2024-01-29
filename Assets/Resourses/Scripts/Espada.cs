using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : MonoBehaviour
{
    //public bool hitjogador;
    public PlayerScpt playerAtingido;
    public event Action<int> hit;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerScpt>(out playerAtingido))
        {
            hit?.Invoke(playerAtingido.Souls);
        }
        Debug.Log("aaaaaaaaaaaaaa");
    }
}
