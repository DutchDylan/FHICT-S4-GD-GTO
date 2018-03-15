using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int pID { get; private set; }
    private string pName;
    private List<GameResource> pResources; //Specifically for non-unit resources
    private List<GameResource> pInventory; //Specifically for units

    public Player(int id, string name)
    {
        pID = id;
        pName = name;
        pResources = new List<GameResource>();
        pInventory = new List<GameResource>();
    }
    public Player(int id, string name, List<GameResource> resources, List<GameResource> inventory)
    {
        pID = id;
        pName = name;
        pResources = resources;
        pInventory = inventory;
    }

    public void ChangeName(string name)
    {
        pName = name;
    }
    

}
