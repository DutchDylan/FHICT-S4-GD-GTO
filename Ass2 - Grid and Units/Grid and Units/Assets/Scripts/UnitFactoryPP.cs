using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactoryPP : MonoBehaviour
{
    public UnitPP Prototype;
    public MapPP Map;

    public ResourcePP Resource;
    public int Cost;

    public int x;
    public int y;

    public void SpawnUnit(/* UnitPP unit */)
    {
        if(ResourcePP.CanAfford(Cost))
        {
            Resource.RemoveAmount(Cost);
            UnitPP newUnit = Instantiate(Prototype);
            CellPP cell = Map.GetCell(x, y);

            newUnit.transform.SetParent(cell.transform, false);
        }

        UnitPP newUnit = Instantiate(Prototype);
        CellPP CellPP = Map.GetCell(x, y);

        newUnit.transform.SetParent(CellPP.transform);
    }
    public void SpawnSpearman()
    {

    }
}
