using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "BuildingDatabase", menuName = "Scriptable Objects/BuildingDatabase")]
public class BuildingDatabase : ScriptableObject
{
 public List<BuildingData> Buildings = new();   
}
