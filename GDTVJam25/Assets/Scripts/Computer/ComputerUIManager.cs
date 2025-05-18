using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComputerUIManager : MonoBehaviour
{
    public GameObject auftragButtonPrefab; // Prefab mit AuftragEintragUI
    public Transform contentParent;        // Inhalt der ScrollView
    public TextMeshProUGUI beschreibungText; // Infotext

    private Auftrag aktuellAusgew�hlt;

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
        aktuellAusgew�hlt = auftrag;
        beschreibungText.text = auftrag.beschreibung;
    }

    public void Annehmen(Auftrag auftrag)
    {
        Debug.Log("Auftrag angenommen: " + auftrag.titel);
        // z.?B. speichern im GameManager oder n�chste Szene laden
        // GameManager.Instance.aktiverAuftrag = auftrag;
        SceneManager.LoadScene("TerrariumAuswahl"); // oder was auch immer
    }

    public void Ablehnen()
    {
        aktuellAusgew�hlt = null;
        beschreibungText.text = "";
    }
}
