using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactoryPP : MonoBehaviour
{
    public UnitPP Prototype;
    public MapPP Map;

    public int x;
    public int y;

    public void SpawnUnit(UnitPP unit)
    {
        UnitPP newUnit = Instantiate(Prototype);
        CellPP CellPP = Map.GetCell(x, y);

        newUnit.transform.SetParent(CellPP.transform)
    }
    public void SpawnSpearman()
    {

    }
}
