using System;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputManager : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private SaveManager saveManager;

    [SerializeField]
    private BuildingData farmData;

    [SerializeField]
    private BuildingData houseData;

    [SerializeField]
    private BuildingData stoneMineData;

    [SerializeField]
    private BuildingData woodHouseData;

    [SerializeField]
    private BuildingData selectedBuilding;

    public BuildingData SelectedBuilding => selectedBuilding; //The name 'selectedBuilding' does not exist in the current contextCS0103


    [SerializeField]
    private CitySave citySave;


    void Awake()
    {
    }


    void Update()
    {
        if (Keyboard.current == null)
            return;


        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            selectedBuilding = farmData;
        }

        if (Keyboard.current.hKey.wasPressedThisFrame)
        {
            selectedBuilding = houseData;
        }

        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            selectedBuilding = stoneMineData;
        }

        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            selectedBuilding = woodHouseData;
        }

        if (Keyboard.current.f9Key.wasPressedThisFrame)
        {
            saveManager.Save("save.json");
        }

        if (Keyboard.current.f10Key.wasPressedThisFrame)
        {
            saveManager.Load();
        }
    }
}