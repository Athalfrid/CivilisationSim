using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI infoText;

    void Update()
    {


        if (gameManager == null || infoText == null)
            return;

        City city = gameManager.city;
        if(city == null)
            return;

        /*CityResource food = city.GetResource(
            gameManager.ResourceDatabase.GetResource("food"));

        CityResource wood = city.GetResource(
            gameManager.ResourceDatabase.GetResource("wood"));

        CityResource stone = city.GetResource(
            gameManager.ResourceDatabase.GetResource("stone"));

        CityResource iron = city.GetResource(
        gameManager.ResourceDatabase.GetResource("iron"));

        CityResource gold = city.GetResource(
            gameManager.ResourceDatabase.GetResource("gold"));*/

        string resourcesText = "";
        foreach (CityResource resource in city.Resources)
        {
            resourcesText += $"{resource.Data.ResourceName} : {resource.Amount}\n";
        }



        infoText.text =
            "Année : " + gameManager.GetYear()
            + "\nPopulation : "
            + city.Population
            + "/"
            + city.GetHousingCapacity()
            + "\n"
            + resourcesText;

    }
}