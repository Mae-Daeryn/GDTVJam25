using System.Collections.Generic;

[System.Serializable]
public class Task
{
    public string subject;
    public string description;
    public string sender;
    public string sendermail;
    public string mailContent;

    public TerrariumType type;
    public List<string> criteria;
    public List<string> criteriaOptional;
}
