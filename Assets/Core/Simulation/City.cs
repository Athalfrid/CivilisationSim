using UnityEngine;
using System.Collections.Generic;

public class City
{
    public string Name;

    public int BaseHousing = 10;

    public int Population;

    public List<CityResource> Resources = new List<CityResource>();
    private ResourceDatabase resourceDatabase;


    public List<Building> Buildings = new List<Building>();

    public City(string name, ResourceDatabase resourceDatabase)
    {
        this.resourceDatabase = resourceDatabase;

        Name = name;
        Population = 10;

        foreach (ResourceData resourceData in resourceDatabase.Resources)
        {
            Resources.Add(new CityResource(resourceData));
        }

        AddResource(resourceDatabase.GetResource(ResourceIds.Food), 1000);
        AddResource(resourceDatabase.GetResource(ResourceIds.Wood), 200);
        AddResource(resourceDatabase.GetResource(ResourceIds.Stone), 200);
        AddResource(resourceDatabase.GetResource(ResourceIds.Iron), 200);
        AddResource(resourceDatabase.GetResource(ResourceIds.Gold), 200);
    }
    private City()
    {

    }

    public CityResource GetResource(ResourceData resourceData)
    {
        return Resources.Find(r => r.Data == resourceData);
    }

    public int GetResourceAmount(ResourceData resourceData)
    {
        CityResource resource = GetResource(resourceData);

        return resource != null ? resource.Amount : 0;
    }

    public void AddResource(ResourceData resourceData, int amount)
    {
        CityResource resource = GetResource(resourceData);

        if (resource != null)
        {
            resource.Amount += amount;
        }
    }

    public bool RemoveResource(ResourceData resourceData, int amount)
    {
        CityResource resource = GetResource(resourceData);

        if (resource == null || resource.Amount < amount)
            return false;

        resource.Amount -= amount;
        return true;
    }

    public void Tick()
    {

        foreach (Building building in Buildings)
        {
            foreach (ProductionData production in building.Data.Productions)
            {
                if (Random.Range(0f, 100f) <= production.Chance)
                {
                    AddResource(production.Resource, production.Amount);
                }
            }
        }


        CityResource food = GetResource(resourceDatabase.GetResource(ResourceIds.Food));

        if (food != null)
        {
            food.Amount -= Population;

            if (food.Amount > Population &&
                Population < GetHousingCapacity())
            {
                Population++;
            }
        }
    }

    public int GetHousingCapacity()
    {
        int capacity = BaseHousing;

        foreach (var building in Buildings)
        {
            capacity += building.Data.HousingCapacity;
        }

        return capacity;
    }

    public bool CanBuild(BuildingData buildingData)
    {
        foreach (ResourceCost cost in buildingData.ConstructionCosts)
        {
            CityResource resource = GetResource(cost.Resource);
            if (resource == null || resource.Amount < cost.Amount)
            {
                return false;
            }
        }

        return true;
    }

    public bool Build(BuildingData buildingData)
    {
        if (!CanBuild(buildingData))
        {
            return false;
        }
        foreach (ResourceCost cost in buildingData.ConstructionCosts)
        {
            CityResource resource = GetResource(cost.Resource);
            if (resource != null)
            {
                resource.Amount -= cost.Amount;
            }
        }

        Buildings.Add(new Building(buildingData));

        return true;
    }

    public CitySave CreateSave()
    {
        CitySave save = new CitySave();
        save.Name = Name;
        save.Population = Population;

        foreach (CityResource resource in Resources)
        {
            CityResourceSave resourceSave = new CityResourceSave();
            resourceSave.ResourceId = resource.Data.Id;
            resourceSave.Amount = resource.Amount;
            save.Resources.Add(resourceSave);
        }

        foreach (Building building in Buildings)
        {
            BuildingSave buildingSave = new BuildingSave();
            buildingSave.BuildingId = building.Data.Id;
            save.Buildings.Add(buildingSave);
        }
        return save;
    }

    public static City FromSave(CitySave save, ResourceDatabase resourceDatabase, BuildingDatabase buildingDatabase)
    {
        City city = new City();
        city.Name = save.Name;
        city.Population = save.Population;
        city.resourceDatabase = resourceDatabase;

        foreach (CityResourceSave resourceSave in save.Resources)
        {
            ResourceData data = resourceDatabase.GetResource(resourceSave.ResourceId);
            CityResource resource = new CityResource(data, resourceSave.Amount);
            city.Resources.Add(resource);
        }

        foreach (BuildingSave buildingSave in save.Buildings)
        {
            Building building = new Building(buildingDatabase.GetBuilding(buildingSave.BuildingId));
            city.Buildings.Add(building);
        }

        return city;
    }
}
