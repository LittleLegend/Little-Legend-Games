using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController{

     int _combo;
     int _points;
    public List<People> PeopleList;
    public UIController UIController;

    public ScoreController(UIController UIController)
    {
        this.UIController = UIController;
        PeopleList = new List<People>();
    }

	public void SetCombo(int combo)
    {
        _combo = combo;
        UIController.SetComboLabel(_combo);
    }

    public void SetPoints(int points)
    {
        _points = points;
        UIController.SetPointLabel(_points);
    }

    public int GetCombo()
    {
        return _combo;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void AddCombo(int combo)
    {
        _combo += combo;
        UIController.SetComboLabel(_combo);
    }

    public void AddPoints(int points)
    {
        _points += points;
        UIController.SetPointLabel(_points);
    }

     public void ResetCombo()
    {
        _combo = 0;
        UIController.SetComboLabel(_combo);
    }

}
