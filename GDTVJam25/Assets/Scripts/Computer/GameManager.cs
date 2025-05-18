using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<Auftrag> alleAuftr�ge = new List<Auftrag>();
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

        // Beispiel-Auftr�ge generieren
        if (alleAuftr�ge.Count == 0)
        {
            alleAuftr�ge.Add(new Auftrag
            {
                titel = "W�stenauftrag",
                beschreibung = "Erstelle ein W�stenterrarium mit 2 W�stenpflanzen.",
                ben�tigterTyp = TerrariumType.W�ste,
                pflichtKriterien = new List<string> { "2 W�stenpflanzen" },
                bonusKriterien = new List<string> { "Deko" }
            });

            alleAuftr�ge.Add(new Auftrag
            {
                titel = "Regenwaldjob",
                beschreibung = "Ein tropisches Zuhause bitte!",
                ben�tigterTyp = TerrariumType.Regenwald,
                pflichtKriterien = new List<string> { "3 Regenwaldpflanzen" },
                bonusKriterien = new List<string> { "Kletter�ste" }
            });
        }
    }
}
