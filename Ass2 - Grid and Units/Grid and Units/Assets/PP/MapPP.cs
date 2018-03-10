using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPP : MonoBehaviour
{
    /*
    public int SizeX;
    public int SizeY;

    public float TileOffset;

    public CellPP Prototype;

    //public List<Cell> Cells;

    public void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        float xOffset = 0;
        for (int i = 0; i < SizeX; i++)
        {
            float yOffset = 0;
            for (int j = 0; i < SizeY; i++)
            {
                CellPP newTile = Instantiate(Prototype);
                newTile.transform.SetParent(transform);
                newTile.transform.localPosition = new Vector3(xOffset, 0, yOffset);
                newTile.name = string.Format("Cell {0}x{1}",i,j);

                newTile.X = i;
                newTile.Y = j;

                yOffset += TileOffset;
            }
            xOffset += TileOffset;
        }
    }
    
    [ContextMenu("Test Cell 3,4")]
    public void Test()
    {
        CellPP test = GetCell(3, 4);
        Debug.Log(test.name, test);
    }

    public CellPP GetCell(int x, int y)
    {
        //CellPP()
        //List<CellPP>
        //Cell[,]
        if (x > SizeX || y == SizeY)
        {
            Debug.Log("Out of Bounds");
            return null;
        }

        return transform.GetChild((x * SizeX) + y ).GetComponent<CellPP>();
    }
    */
}
