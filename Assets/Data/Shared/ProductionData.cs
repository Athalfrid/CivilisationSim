using UnityEngine;

[System.Serializable]
public class ProductionData
{
    public ResourceData Resource;
    public int Amount;
    [Range(0, 100)]
    public float Chance = 100;
}
