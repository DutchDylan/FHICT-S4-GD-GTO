using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    public int tID { get; private set; }
    public Tile tNorth;
    public Tile tEast;
    public Tile tSouth;
    public Tile tWest;

    public Tile(int id)
    {
        tID = id;
    }

    public void addTileNorth(Tile basetile, Tile addingtile)
    {
        basetile.tNorth = addingtile;
        addingtile.tSouth = basetile;
    }
    public void addTileEast(Tile basetile, Tile addingtile)
    {
        basetile.tEast = addingtile;
        addingtile.tWest = basetile;
    }
    public void addTileSouth(Tile basetile, Tile addingtile)
    {
        basetile.tSouth = addingtile;
        addingtile.tNorth = basetile;
    }
    public void addTileWest(Tile basetile, Tile addingtile)
    {
        basetile.tWest = addingtile;
        addingtile.tEast = basetile;
    }
}
