//using UnityEngine;

//public class TerrariumSlot : MonoBehaviour
//{
//    public int index;
//    public TMPro.TextMeshProUGUI statusText;

//    public void Init(int idx)
//    {
//        index = idx;
//        UpdateStatus();
//    }

//    public void OnClick()
//    {
//        Auftrag a = GameManager.Instance.alleAufträge.Find(x => x.angenommen && x.terrariumIndex == index);

//        if (a != null)
//        {
//            GameManager.Instance.aktiverAuftrag = a;
//            UnityEngine.SceneManagement.SceneManager.LoadScene("DekorierenSzene");
//        }
//    }

//    public void UpdateStatus()
//    {
//        Auftrag a = GameManager.Instance.alleAufträge.Find(x => x.angenommen && x.terrariumIndex == index);

//        if (a == null) statusText.text = "Frei";
//        else statusText.text = a.dekoriert ? "Fertig" : "Dekorieren";
//    }
//}
