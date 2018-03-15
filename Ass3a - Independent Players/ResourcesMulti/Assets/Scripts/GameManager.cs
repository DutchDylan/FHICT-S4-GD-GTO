using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Player> players; //So that Unity can take control of the amount of players;
    private Player currentPlayer;

    public List<GameResource> resources;

    void Start()
    {
        //Player playa = new Player(0, "Henk");
        //players.Add(playa);

        /*
        players.Add(new Player(0, "Player One"));
        players.Add(new Player(1, "Player Two"));
        players.Add(new Player(2, "Player Three"));
        players.Add(new Player(3, "Player Four"));
        currentPlayer = players[0];
        */ //not allowed, list should be public and accessible by Unity
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

    private void Update()
    {
        //LabelWood.text = Wood.ToString();
        //LabelGold.text = Gold.ToString();
        //LabelSoldiers.text = Soldiers.ToString();
    }

}
