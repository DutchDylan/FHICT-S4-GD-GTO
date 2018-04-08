using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainGame : MonoBehaviour
{
    public Button NexPlayerButton;
    public Button DiceRollButton;

    public Button MoveNorthButton;
    public Button MoveEastButton;
    public Button MoveSouthButton;
    public Button MoveWestButton;

    public Text LabelPlayerOne;
    public Text LabelPlayerTwo;
    public Text LabelPlayerThree;
    public Text LabelPlayerFour;

    private List<Player> players; //List of all the players
    private Player currentPlayer; //Current Player

    private int diceThrow; //Starting movement
    //private int diceLeft; //Movement left
    private Tile originalTile; //Starting Tile
    //private Tile currentTile; //Current Tile
    private List<Tile> possibleTiles; //Possible ending Tiles

    // Use this for initialization
    void Start ()
    {
        NexPlayerButton.onClick.AddListener(NextPlayer);
        DiceRollButton.onClick.AddListener(RollDice);




        players.Add(new Player(0, "Player One")); //ready Player One
        players.Add(new Player(1, "Player Two"));
        players.Add(new Player(2, "Player Three"));
        players.Add(new Player(3, "Player Four"));


    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void NextPlayer() //Advance to next player
    {
        int id = currentPlayer.pID + 1;
        if (players[id] == null)
        {
            players[id] = players[0];
        }
        currentPlayer = players[id];
    }

    public void RollDice() //Generate random number
    {
        diceThrow = Random.Range(1, 7);
    }

    public void GenerateMovement() //Determine valid paths
    {
        checkTile(originalTile, originalTile, diceThrow);
        foreach(Tile tile in possibleTiles)
        {

        }

        /*
        for (int i = 0; i < diceThrow; i++)
        {
            currentTile
        }
        */
    }

    public void checkTile(Tile prevTile, Tile currTile, int left)
    {
        if(left == 0)
        {
            possibleTiles.Add(currTile);
        }
        else
        {
            if (currTile.tNorth != null /* && currTile.tNorth != prevTile */) //might crash if it is null
            {
                if (currTile.tNorth.tID != prevTile.tID) //actually use id for something
                {
                    checkTile(currTile, currTile.tNorth, left--);
                }
            }
            if (currTile.tEast != null)
            {
                if (currTile.tEast.tID != prevTile.tID)
                {
                    checkTile(currTile, currTile.tEast, left--);
                }
            }
            if (currTile.tSouth != null)
            {
                if (currTile.tSouth.tID != prevTile.tID)
                {
                    checkTile(currTile, currTile.tSouth, left--);
                }
            }
            if (currTile.tWest != null)
            {
                if (currTile.tWest.tID != prevTile.tID)
                {
                    checkTile(currTile, currTile.tWest, left--);
                }
            }
        }
    }


}
