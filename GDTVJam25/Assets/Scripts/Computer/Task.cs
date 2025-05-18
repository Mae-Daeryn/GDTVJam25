using System.Collections.Generic;

[System.Serializable]
public class Task
{
    public string title;
    public string shortDescription;
    public string description;

    public TerrariumTyp type;
    public List<string> criteria;
    public List<string> criteriaOptional;
}
