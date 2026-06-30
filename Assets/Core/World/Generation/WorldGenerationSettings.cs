using System;
using UnityEngine;

[Serializable]
public class WorldGenerationSettings
{
    
    public int Width = 20;
    public int Height = 20;
    
    public int Seed = 12345;
    public float Scale = 0.08f;
    public float WaterLevel = 0.30f;
    public float ForestLevel = 0.60f;
    public float MountainLevel = 0.85f;
}
