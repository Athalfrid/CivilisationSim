using UnityEngine;

public static class TerrainGenerator
{
    public static TerrainType Generate(int x, int y, WorldGenerationSettings settings)
    {
        float value = Mathf.PerlinNoise((x + settings.Seed) * settings.Scale, (y + settings.Seed) * settings.Scale);

        if (value < settings.WaterLevel)
            return TerrainType.Water;

        if (value < settings.ForestLevel)
            return TerrainType.Grass;

        if (value < settings.MountainLevel)
            return TerrainType.Forest;

        return TerrainType.Stone;
    }
}
