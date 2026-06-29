using UnityEngine;

public class CityResource
{
    public ResourceData Data;
    public int Amount;
    public CityResource(ResourceData data, int amount = 0)
    {
        Data = data;
        Amount = amount;
    }
}
