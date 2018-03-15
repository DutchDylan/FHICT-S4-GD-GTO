using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private List<Player> players;
    private Player currentPlayer;

    void Start()
    {
        //Player playa = new Player(0, "Henk");
        //players.Add(playa);
        players.Add(new Player(0, "Player One"));
        players.Add(new Player(1, "Player Two"));
        players.Add(new Player(2, "Player Three"));
        players.Add(new Player(3, "Player Four"));
        currentPlayer = players[0];
    }

    public void NextPlayer() 
    {
        int id = currentPlayer.pID + 1;
        if (players[id] != null)
        {
            currentPlayer = players[id];
        }
        else
        {
            players[id] = players[0];
        }
    }

    	

}
