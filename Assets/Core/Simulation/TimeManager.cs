using UnityEngine;

public class TimeManager
{
    public int Year {get; private set;}

    public TimeManager()
    {
        Year = 0;
    }

    public void Tick()
    {
        Year++;
    }

    public void Load(int year)
    {
        Year = year;
    }
}
