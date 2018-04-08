using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainGame : MonoBehaviour
{
    public Button NexPlayerButton;
    public Button DiceRollButton;
    public Button MovementButton;

    public Text LabelPlayerOne;
    public Text LabelPlayerTwo;
    public Text LabelPlayerThree;
    public Text LabelPlayerFour;

    private List<Player> players; //List of all the players
    private Player currentPlayer; //Current Player

    /*
    Player playa1 = new Player(0, "Player One");
    Player playa2 = new Player(1, "Player Two");
    Player playa3 = new Player(2, "Player Three");
    Player playa4 = new Player(3, "Player Four");
    */

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
        MovementButton.onClick.AddListener(moveToTile);

        /*
        players.Add(playa1); //ready Player One
        players.Add(playa2);
        players.Add(playa3);
        players.Add(playa4);
        */

        /*
        Player playa = new Player(0, "Player One");
        players.Add(playa); //ready Player One
        playa = new Player(1, "Player Two");
        players.Add(playa); //ready Player Two
        playa = new Player(2, "Player Three");
        players.Add(playa); //ready Player Three
        playa = new Player(3, "Player Four");
        players.Add(playa); //ready Player Four
        */

        /*
        players.Add(new Player(0, "Player One")); //ready Player One
        players.Add(new Player(1, "Player Two"));
        players.Add(new Player(2, "Player Three"));
        players.Add(new Player(3, "Player Four"));
        */


        currentPlayer = players[0];


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
            id = 0;
        }
        currentPlayer = players[id];

        Refresh();
    }

    public void Refresh()
    {
        NexPlayerButton.interactable = false;

        diceThrow = 0;
        DiceRollButton.interactable = true;

        originalTile = currentPlayer.pTile;
        possibleTiles.Clear();
    }

    public void RollDice() //Generate random number
    {
        diceThrow = Random.Range(1, 7);
        DiceRollButton.interactable = false;
        MovementButton.interactable = true;
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

    public void moveToTile()
    {
        MovementButton.interactable = false;
        if (currentPlayer.pWinpoints == 5)
        {
            //enable 'a winner is you' text on screen, everything disabled
        }
        else
        {
            NexPlayerButton.interactable = true;
        }
    }

}
