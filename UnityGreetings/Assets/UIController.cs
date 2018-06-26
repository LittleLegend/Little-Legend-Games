using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public References References;
    public TextMeshProUGUI ComboLabel;
    public TextMeshProUGUI PointLabel;

    Player Player;

    public void Start()
    {
        Player = References.Player;
    }

    public void SetPointLabel(int points)
    {
        PointLabel.text =  points.ToString(); 
    }

    public void SetComboLabel(int combo)
    {
        ComboLabel.text = "x"+combo.ToString();
    }

    public void OpenDoorButton(int ButtonTrigger)
    {
        if (ButtonTrigger == 0)
        {

        }
        else
        {
            
            Player.openDoor();
        }

    }
}
