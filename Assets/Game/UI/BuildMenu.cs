using UnityEngine;

public class BuildMenu : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private BuildingDatabase buildingDatabase;

    [SerializeField] private BuildButton buttonPrefab;

    void Start()
    {
        foreach (BuildingData building in buildingDatabase.Buildings)
        {
            BuildButton button = Instantiate(buttonPrefab, transform);
            button.Initialize(building);
        }
    }

    void Update()
    {

    }
}
