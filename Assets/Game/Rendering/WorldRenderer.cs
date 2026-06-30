using UnityEngine;
using UnityEngine.Rendering.Universal;

public class WorldRenderer : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    [SerializeField]
    private GameObject tilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        RenderWorld();
    }

    private void RenderWorld()
    {
        for (int y = 0; y < gameManager.world.Height; y++)
        {
            for (int x = 0; x < gameManager.world.Width; x++)
            {
                GameObject tileObject = Instantiate(tilePrefab, transform);
                TileView tileView = tileObject.GetComponent<TileView>();
                Tile tileData = gameManager.world.GetTile(x, y);

                tileView.Tile = tileData;
                
                tileObject.transform.position = new Vector3(x, 0, y);


                Renderer renderer = tileObject.GetComponent<Renderer>();

                renderer.material.color = GetTerrainColor(tileData.TerrainType);
            }
        }
    }

    private Color GetTerrainColor(TerrainType terrainType)
    {
        switch (terrainType)
        {
            case TerrainType.Grass:
                return Color.green;

            case TerrainType.Forest:
                return new Color(0f, 0.4f, 0f);

            case TerrainType.Stone:
                return Color.gray;

            case TerrainType.Water:
                return Color.blue;
            default:
                return Color.magenta;
        }
    }
}
