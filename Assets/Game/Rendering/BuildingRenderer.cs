using System.Collections.Generic;
using UnityEngine;

public class BuildingRenderer : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    private Dictionary<Building, GameObject> renderedBuildings = new();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Building building in gameManager.city.Buildings)
        {
            if (renderedBuildings.ContainsKey(building))
            {
                continue;
            }
            Vector3 position = new Vector3(
                building.OriginTile.X,
                0.5f,
                building.OriginTile.Y);

            GameObject instance = Instantiate(
                building.Data.Prefab,
                position,
                Quaternion.identity,
                transform);

            renderedBuildings.Add(building, instance);

        }

    }
}
