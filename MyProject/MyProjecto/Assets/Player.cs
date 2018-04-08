using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int pID { get; private set; }
    private string pName;
    private int pWinpoints;
    public Tile pTile;

    public Player(int id, string name)
    {
        pID = id;
        pName = name;
        pWinpoints = 0;
    }

    public void ChangeName(string name)
    {
        pName = name;
    }

    public void AddWinpoint()
    {
        pWinpoints++;
    }
}
