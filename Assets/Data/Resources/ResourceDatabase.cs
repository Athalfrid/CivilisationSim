using UnityEngine;
using System.Collections.Generic;
using System.Linq;

[CreateAssetMenu(fileName = "ResourceDatabase", menuName = "Scriptable Objects/ResourceDatabase")]
public class ResourceDatabase : ScriptableObject
{
    public List<ResourceData> Resources = new();

    public ResourceData GetResource(string id)
    {
        foreach (ResourceData resource in Resources)
        {
            if(resource.Id == id)
            {
                return resource;
            }
        }
        return null;
    }
}
