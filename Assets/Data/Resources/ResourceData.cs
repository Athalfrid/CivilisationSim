using UnityEngine;

[CreateAssetMenu(fileName = "ResourceData", menuName = "Scriptable Objects/ResourceData")]
public class ResourceData : ScriptableObject
{
    [Header("Identification")]
    public string Id;
    public string ResourceName;
    public Sprite Icon;
    public string Description;
}
