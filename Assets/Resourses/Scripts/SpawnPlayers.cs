using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayers : MonoBehaviour
{
    public int numOfPlayers;
    [SerializeField] BaseScript[] listOfBases;

    public BaseScript[] ListofBases => listOfBases ;

    public event Action Spawned;
    public static SpawnPlayers instance;




    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        for(int i = 0; i < numOfPlayers; i++)
        {
            listOfBases[i].SpawnPlayer();
            //Debug.Log(i);
        }

        Spawned?.Invoke();
    }

    
}
