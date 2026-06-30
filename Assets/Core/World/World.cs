using System.Collections.Generic;

public class World
{
    public int Width;
    public int Height;
    public Tile[,] Tiles;

    public World(int width, int height)
    {
        Width = width;
        Height = height;
        Tiles = new Tile[Width, Height];


    }

    public Tile GetTile(int x, int y)
    {
        if (x < 0 || x >= Width || y < 0 || y >= Height)
        {
            return null;
        }
        return Tiles[x, y];
    }

    public WorldSave CreateSave()
    {
        WorldSave save = new WorldSave();
        save.Width = Width;
        save.Height = Height;
        return save;
    }

}
