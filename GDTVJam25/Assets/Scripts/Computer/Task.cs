using System.Collections.Generic;

[System.Serializable]
public class Task
{
    public string title;
    public string shortDescription;
    public string description;

    public TerrariumType type;
    public List<string> criteria;
    public List<string> criteriaOptional;
}
