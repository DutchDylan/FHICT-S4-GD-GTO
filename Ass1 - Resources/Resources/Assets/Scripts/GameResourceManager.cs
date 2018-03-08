using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameResourceManager : MonoBehaviour
{
    GameResource Wood = new GameResource("Wood");
    GameResource Gold = new GameResource("Gold");
    GameResource Soldiers = new GameResource("Soldiers");

    public Button AddButton;
    public Button RemoveButton;
    public Button AquireButton;

    public Text LabelWood;
    public Text LabelGold;
    public Text LabelSoldiers;

    void Start()
    {
        Wood.Increase(500);
        Gold.Increase(20);
        Soldiers.Increase(1);
        AddButton.onClick.AddListener(AddWood);
    }

    public void AddWood()
    {
        Wood.Increase(20);
    }
    public void RemovedWood()
    {
        Wood.Decrease(20);
    }
    public void AquireSoldier()
    {
        Wood.Decrease(50);
        Gold.Decrease(10);
        Soldiers.Increase(1);
    }

    private void Update()
    {
        LabelWood.text = Wood.ToString();
        LabelGold.text = Gold.ToString();
        LabelSoldiers.text = Soldiers.ToString();
    }
}
