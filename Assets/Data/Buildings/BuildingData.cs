using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "BuildingData", menuName = "Scriptable Objects/BuildingData")]
public class BuildingData : ScriptableObject
{
    [Header("Identification")]
    public string Id;
    public string BuildingName;
    public Sprite Icon;

    [Header("Production")]
    public List<ProductionData> Productions = new();

    [Header("Housing")]
    public int HousingCapacity;

    [Header("Construction Costs")]
    public List<ResourceCost> ConstructionCosts = new();

    [Header("Dimensions")]  
    public int Width = 1;
    public int Height = 1;
}
