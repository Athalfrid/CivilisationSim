
public class Tile
{
    public int X;
    public int Y;
    public TerrainType TerrainType;

    public Building Building {get; set;}

    public Tile(int x, int y, TerrainType terrainType)
    {
        X = x;
        Y = y;
        TerrainType = terrainType;
    }
}
