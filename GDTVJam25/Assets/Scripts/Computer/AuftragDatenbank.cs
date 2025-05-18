using System.Collections.Generic;

public static class AuftragDatenbank
{
    public static List<Auftrag> Alle = new List<Auftrag>
    {
        new Auftrag
        {
            titel = "Gecko-Terrarium",
            kurzeBeschreibung = "Ein W�sten-Terrarium f�r einen Gecko.",
            beschreibung = "Ein Kunde m�chte ein Terrarium f�r einen Gecko mit 2 W�stenpflanzen und 1 W�rmelampe.",
            typ = TerrariumTyp.Wueste,
            pflichtKriterien = new List<string> { "2 W�stenpflanzen", "1 W�rmelampe" },
            optionaleKriterien = new List<string> { "Deko: Totensch�del", "W�stenstein" }
        },
        new Auftrag
        {
            titel = "Frosch-Terrarium",
            kurzeBeschreibung = "Ein Regenwald-Terrarium f�r Fr�sche.",
            beschreibung = "Regenwald-Stimmung mit viel Feuchtigkeit und Pflanzen.",
            typ = TerrariumTyp.Regenwald,
            pflichtKriterien = new List<string> { "2 Regenwaldpflanzen", "1 Nebelmaschine" },
            optionaleKriterien = new List<string> { "Moos", "Hintergrundbild" }
        }
    };
}
