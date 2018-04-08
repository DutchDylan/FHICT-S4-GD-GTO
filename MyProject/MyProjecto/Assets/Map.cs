using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public List<Tile> mTiles;

    void Start()
    {
        for(int i = 0; i < 11; i++)
        {
            mTiles.Add(new Tile(i));
        }

        mTiles[0].addTileSouth(mTiles[0], mTiles[1]);


    }

    
}
