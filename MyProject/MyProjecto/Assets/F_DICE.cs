using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_DICE : MonoBehaviour {

    Random rnd;
    public void Start()
    {
        rnd = new Random();
    }

    public int RollD6()
    {
        //return rnd.Next(1, 7); // creates a number between 1 and 6
        return 1; //temp
    }

}
