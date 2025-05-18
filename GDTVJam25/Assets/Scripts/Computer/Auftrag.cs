using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum TerrariumType { W�ste, Wasser, Regenwald }

[System.Serializable]
public class Auftrag
{
    public string titel;
    public string beschreibung;
    public TerrariumType ben�tigterTyp;
    public List<string> pflichtKriterien;
    public List<string> bonusKriterien;
    public bool angenommen;
    public int terrariumIndex = -1;
    public bool dekoriert;
}
