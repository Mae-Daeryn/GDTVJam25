using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComputerUIManager : MonoBehaviour
{
    public GameObject auftragButtonPrefab; // Prefab mit AuftragEintragUI
    public Transform contentParent;        // Inhalt der ScrollView
    public TextMeshProUGUI beschreibungText; // Infotext

    private Auftrag aktuellAusgewählt;

    void Start()
    {
        foreach (var auftrag in AuftragDatenbank.Alle)
        {
            GameObject eintrag = Instantiate(auftragButtonPrefab, contentParent);
            eintrag.GetComponent<AuftragEintragUI>().Setup(auftrag, this);
        }
    }

    public void ZeigeBeschreibung(Auftrag auftrag)
    {
        aktuellAusgewählt = auftrag;
        beschreibungText.text = auftrag.beschreibung;
    }

    public void Annehmen(Auftrag auftrag)
    {
        Debug.Log("Auftrag angenommen: " + auftrag.titel);
        // z.?B. speichern im GameManager oder nächste Szene laden
        // GameManager.Instance.aktiverAuftrag = auftrag;
        SceneManager.LoadScene("TerrariumAuswahl"); // oder was auch immer
    }

    public void Ablehnen()
    {
        aktuellAusgewählt = null;
        beschreibungText.text = "";
    }
}
