using UnityEngine;

public class Building
{
    public BuildingData Data;
    public Tile OriginTile { get; set; }

    public Building(BuildingData data)
    {
        Data = data;
    }
}
