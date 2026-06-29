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


    void Awake()
    {
    }


    void Update()
    {
        if (Keyboard.current == null)
            return;


        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            Build(farmData);
        }

        if (Keyboard.current.hKey.wasPressedThisFrame)
        {
            Build(houseData);
        }

        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            Build(stoneMineData);
        }

        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            Build(woodHouseData);
        }

        if (Keyboard.current.f9Key.wasPressedThisFrame)
        {
            saveManager.Save();
        }
    }



    void Build(BuildingData buildingData)
    {
        
        if (gameManager.city.Build(buildingData))
        {
            Debug.Log(buildingData.BuildingName+" construit !");
        }
        else
        {
            Debug.Log("Pas assez de ressources");
        }
    }


    
}