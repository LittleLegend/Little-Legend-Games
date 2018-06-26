using System.Collections;
using System.Collections.Generic;
using Enums;
using UnityEngine;

public class DataManager : MonoBehaviour {

    public BalancingData BalancingData;
    public TextAsset BalancingDataCSV;
    public PeopleData PeopleData;
    public TextAsset PeopleDataCSV;
    
	public void Load()
    {
        BalancingData = new BalancingData();
        PeopleData = new PeopleData();

        BalancingData.Load(BalancingDataCSV);
        PeopleData.Load(PeopleDataCSV);
    }

    public Roles GetTypeByName(string name)
    {
        Roles result = Roles.None;

        switch (name)
        {
            case "mother":
                result = Roles.Mother;
                break;

            case "friend":
                result = Roles.Friend;
                break;

            case "boss":
                result = Roles.Boss;
                break;

            case "wife":
                result = Roles.Wife;
                break;
        }
        return result;
    }

    public Greetings GetWantedGreetingByName(string name)
    {
        string wantedGreetingString = PeopleData.Find_name(name).greeting;
        Greetings result = Greetings.None;

        switch(wantedGreetingString)
        {
            case "hug":
                result = Greetings.Hug;
                break;

            case "kiss":
                result = Greetings.Kiss;
                break;

            case "bump":
                result = Greetings.Bump;
                break;

            case "shake":
                result = Greetings.Shake;
                break;
        }
        return result;
    }

    public int GetPoints(string name)
    {
        return int.Parse(PeopleData.Find_name(name).points);
    }

    public int GetCombo(string name)
    {
        return int.Parse(PeopleData.Find_name(name).combo);
    }

    public float GetTimeFactor(string name)
    {
        return float.Parse(PeopleData.Find_name(name).timeFactor);
    }

    public float GetMaxGreetTime(int points)
    {
        float result=0;

        for(int i=0; i < BalancingData.NumRows();i++)
        {
            if(int.Parse(BalancingData.GetAt(i).points) > points)
            { 
                result = float.Parse(BalancingData.GetAt(i).time);
                break;
            }
            
        }
        return result;
    }
}
