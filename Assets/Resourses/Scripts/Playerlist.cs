using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerlist : MonoBehaviour
{
    //public PlayerScpt[] players;
    public List<PlayerScpt> players;

    public static Playerlist Instance{ get; set; }
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        
    }

    public void AddPlayer(PlayerScpt player)
    {
        players.Add(player);

        //for (int i = 0; i < players.Length; i++)
        //{
        //    if (players[i] == null)
        //    {
        //        players[i] = player;
        //        break;
        //    }
        //}
    }
    
}
