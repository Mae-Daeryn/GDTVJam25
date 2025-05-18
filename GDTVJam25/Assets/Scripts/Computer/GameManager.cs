using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<Auftrag> alleAufträge = new List<Auftrag>();
    public Auftrag aktiverAuftrag;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // Beispiel-Aufträge generieren
        if (alleAufträge.Count == 0)
        {
            alleAufträge.Add(new Auftrag
            {
                titel = "Wüstenauftrag",
                beschreibung = "Erstelle ein Wüstenterrarium mit 2 Wüstenpflanzen.",
                benötigterTyp = TerrariumType.Wüste,
                pflichtKriterien = new List<string> { "2 Wüstenpflanzen" },
                bonusKriterien = new List<string> { "Deko" }
            });

            alleAufträge.Add(new Auftrag
            {
                titel = "Regenwaldjob",
                beschreibung = "Ein tropisches Zuhause bitte!",
                benötigterTyp = TerrariumType.Regenwald,
                pflichtKriterien = new List<string> { "3 Regenwaldpflanzen" },
                bonusKriterien = new List<string> { "Kletteräste" }
            });
        }
    }
}
