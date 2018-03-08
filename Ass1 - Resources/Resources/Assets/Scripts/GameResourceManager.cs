using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameResourceManager : MonoBehaviour
{
    void Start()
    {
        GameResource Wood = new GameResource("Wood");
        GameResource Gold = new GameResource("Gold");
        GameResource Soldiers = new GameResource("Soldiers");
    }
}
