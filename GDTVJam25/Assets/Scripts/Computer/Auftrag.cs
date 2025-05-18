using System.Collections.Generic;

[System.Serializable]
public class Auftrag
{
    public string titel;
    public string kurzeBeschreibung;
    public string beschreibung;

    public TerrariumTyp typ;
    public List<string> pflichtKriterien;
    public List<string> optionaleKriterien;
}
