using UnityEngine;
using System;

[Serializable]
public class SaveGame
{
    public CitySave City;
    public WorldSave World;
    public int Year;
    public string LastSaveDate;
}
