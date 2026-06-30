using TMPro;
using UnityEngine;

public class BuildButton : MonoBehaviour
{
    private BuildingData buildingData;
    private TMP_Text label;


    private void Awake()
    {
        label = GetComponentInChildren<TMP_Text>();
    }
    public void Initialize(BuildingData buildingData)
    {
        this.buildingData = buildingData;
        label.text = buildingData.BuildingName;
    }
}
