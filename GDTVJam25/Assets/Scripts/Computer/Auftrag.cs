using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum TerrariumType { Wüste, Wasser, Regenwald }

[System.Serializable]
public class Auftrag
{
    public string titel;
    public string beschreibung;
    public TerrariumType benötigterTyp;
    public List<string> pflichtKriterien;
    public List<string> bonusKriterien;
    public bool angenommen;
    public int terrariumIndex = -1;
    public bool dekoriert;
}
