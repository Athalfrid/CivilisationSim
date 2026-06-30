using UnityEngine;
using UnityEngine.InputSystem;

public class TileSelectionManager : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;

    [SerializeField]
    private GameManager gameManager;

    [SerializeField]
    private InputManager inputManager;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!Mouse.current.leftButton.wasPressedThisFrame)
            return;

        BuildingData building = inputManager.SelectedBuilding;

        if (building == null)
        {
            return;
        }


        Ray ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            TileView tileView = hit.collider.GetComponent<TileView>();
            if (tileView != null)
            {
                Tile tile = tileView.Tile;

                if (tile.Building == null)
                {
                    if (gameManager.city.Build(building, tile))
                    {
                        Debug.Log($"{building.BuildingName} construit(e) !");
                    }
                    else
                    {
                        Debug.Log("Construction impossible.");
                    }
                }
                else
                {
                    Debug.Log("Case déjà occupée !");
                }
            }
        }

    }
}
