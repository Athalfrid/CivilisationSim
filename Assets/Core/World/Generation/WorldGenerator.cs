using UnityEngine;

public static class WorldGenerator
{
    public static World Generate(WorldGenerationSettings settings)
    {
        World world = new World(settings.Width, settings.Height);
        for (int y = 0; y < world.Height; y++)
        {
            for (int x = 0; x < world.Width; x++)
            {
                world.Tiles[x, y] = new Tile(x, y, TerrainGenerator.Generate(x, y, settings));
            }
        }
        return world;
    }
}
