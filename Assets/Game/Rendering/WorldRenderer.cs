using UnityEngine;

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
                GameObject tile = Instantiate(tilePrefab, transform);
                Renderer renderer = tile.GetComponent<Renderer>();

                if ((x + y) % 2 == 0)
                {
                    renderer.material.color = Color.green;
                }
                else
                {
                    renderer.material.color = Color.white;
                }
                tile.transform.position = new Vector3(x * 1.02f, 0, y * 1.02f);
            }
        }
    }
}
