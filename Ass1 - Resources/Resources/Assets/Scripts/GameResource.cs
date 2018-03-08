using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameResource : MonoBehaviour
{
    private string rName;
    private float rAmount;

    public GameResource(string name)
    {
        rName = name;
        rAmount = 0;
    }
    public GameResource(string name, float amount)
    {
        rName = name;
        rAmount = amount;
    }

    public void Increase()
    {
        rAmount++;
    }
    public void Increase(int amount )
    {
        rAmount = rAmount + amount;
    }

    public void Decrease()
    {
        rAmount--;
    }
    public void Decrease(int amount)
    {
        rAmount = rAmount - amount;
    }

    public override string ToString()
    {
        return rName + ": " + rAmount;
    }
}
