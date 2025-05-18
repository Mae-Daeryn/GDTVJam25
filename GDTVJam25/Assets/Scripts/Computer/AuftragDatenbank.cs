using System.Collections.Generic;

public static class AuftragDatenbank
{
    public static List<Auftrag> Alle = new List<Auftrag>
    {
        new Auftrag
        {
            titel = "Gecko-Terrarium",
            kurzeBeschreibung = "Ein Wüsten-Terrarium für einen Gecko.",
            beschreibung = "Ein Kunde möchte ein Terrarium für einen Gecko mit 2 Wüstenpflanzen und 1 Wärmelampe.",
            typ = TerrariumTyp.Wueste,
            pflichtKriterien = new List<string> { "2 Wüstenpflanzen", "1 Wärmelampe" },
            optionaleKriterien = new List<string> { "Deko: Totenschädel", "Wüstenstein" }
        },
        new Auftrag
        {
            titel = "Frosch-Terrarium",
            kurzeBeschreibung = "Ein Regenwald-Terrarium für Frösche.",
            beschreibung = "Regenwald-Stimmung mit viel Feuchtigkeit und Pflanzen.",
            typ = TerrariumTyp.Regenwald,
            pflichtKriterien = new List<string> { "2 Regenwaldpflanzen", "1 Nebelmaschine" },
            optionaleKriterien = new List<string> { "Moos", "Hintergrundbild" }
        }
    };
}
