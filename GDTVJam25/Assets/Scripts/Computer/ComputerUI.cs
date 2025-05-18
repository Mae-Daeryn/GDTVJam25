using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ComputerUI : MonoBehaviour
{
    public Transform auftragsContainer;
    public GameObject auftragsButtonPrefab;

    public TextMeshProUGUI detailText;
    public Button annehmenButton;
    public Button ablehnenButton;
    public Button abschlieﬂenButton;

    private Auftrag ausgew‰hlterAuftrag;

    void Start()
    {
        BuildList();
    }

    void BuildList()
    {
        foreach (Transform child in auftragsContainer)
            Destroy(child.gameObject);

        foreach (var auftrag in GameManager.Instance.alleAuftr‰ge)
        {
            GameObject btn = Instantiate(auftragsButtonPrefab, auftragsContainer);
            btn.GetComponentInChildren<TextMeshProUGUI>().text = auftrag.titel;
            btn.GetComponent<Button>().onClick.AddListener(() => SelectAuftrag(auftrag));
        }
    }

    void SelectAuftrag(Auftrag a)
    {
        ausgew‰hlterAuftrag = a;
        detailText.text = $"{a.beschreibung}\nTyp: {a.benˆtigterTyp}\nPflicht: {string.Join(", ", a.pflichtKriterien)}\nBonus: {string.Join(", ", a.bonusKriterien)}";

        annehmenButton.gameObject.SetActive(!a.angenommen);
        abschlieﬂenButton.gameObject.SetActive(a.angenommen && a.dekoriert);
    }

    public void Annehmen()
    {
        ausgew‰hlterAuftrag.angenommen = true;
        GameManager.Instance.aktiverAuftrag = ausgew‰hlterAuftrag;
        UnityEngine.SceneManagement.SceneManager.LoadScene("TerrariumAuswahl");
    }

    public void Ablehnen()
    {
        GameManager.Instance.alleAuftr‰ge.Remove(ausgew‰hlterAuftrag);
        BuildList();
    }

    public void Abschlieﬂen()
    {
        GameManager.Instance.alleAuftr‰ge.Remove(ausgew‰hlterAuftrag);
        BuildList();
    }
}
