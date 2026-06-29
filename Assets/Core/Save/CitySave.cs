using UnityEngine;
using System.Collections.Generic;
using System;

[Serializable]
public class CitySave
{
    public string Name;
    public int Population;
    public List<CityResourceSave> Resources = new ();
    public List<BuildingSave> Buildings = new ();
}
