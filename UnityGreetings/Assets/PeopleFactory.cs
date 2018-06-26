using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;


public class PeopleFactory {

    public DataManager DataManager;
    
    public PeopleFactory(DataManager DataManager)
    {
        this.DataManager = DataManager;
    }

    public People createRandom(int points)
    {
        int rand = Random.Range(1,5);
        People result=null;

        switch (rand)
        {
            case 1:
                result= createPerson(points,"mother");
                break;

            case 2:
                result = createPerson(points, "friend");
                break;

            case 3:
                result = createPerson(points, "wife");
                break;

            case 4:
                result = createPerson(points, "boss");
                break;
        }

        return result;
        }
    
    public People createPerson(int points, string name)
    {
        People result = new People();
        result.Type = DataManager.GetTypeByName(name);
        result.MaxGreetingTime = DataManager.GetMaxGreetTime(points) * DataManager.GetTimeFactor(name);
        result.WantedGreeting = DataManager.GetWantedGreetingByName(name);
        result.points = DataManager.GetPoints(name);
        result.combo = DataManager.GetCombo(name);

        return result;
    }
    
}
