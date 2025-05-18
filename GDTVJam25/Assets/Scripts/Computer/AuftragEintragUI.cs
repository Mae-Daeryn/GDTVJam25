using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AuftragEintragUI : MonoBehaviour
{
    public TextMeshProUGUI titelText;
    public TextMeshProUGUI kurzbeschreibungText;
    public Button annehmenButton;
    public Button ablehnenButton;

    private Auftrag auftrag;
    private ComputerUIManager manager;

    public void Setup(Auftrag a, ComputerUIManager m)
    {
        auftrag = a;
        manager = m;

        titelText.text = a.titel;
        kurzbeschreibungText.text = a.kurzeBeschreibung;

        annehmenButton.onClick.AddListener(() => manager.Annehmen(auftrag));
        ablehnenButton.onClick.AddListener(() => manager.Ablehnen());
        GetComponent<Button>().onClick.AddListener(() => manager.ZeigeBeschreibung(a));
    }
}
