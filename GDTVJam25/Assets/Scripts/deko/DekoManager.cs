using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DekoManager : MonoBehaviour
{
    public Transform platzierteObjekteParent;

    public void FertigDekoriert()
    {
        var auftrag = GameManager.Instance.aktiverAuftrag;

        int pflichtErfüllt = 0;
        int bonusErfüllt = 0;

        List<string> platzierteTypen = new List<string>();
        foreach (Transform child in platzierteObjekteParent)
        {
            var obj = child.GetComponent<PlatzierbareObjekt>();
            if (obj != null)
                platzierteTypen.Add(obj.objektTyp);
        }

        // Pflicht prüfen
        foreach (string kriterium in auftrag.pflichtKriterien)
        {
            if (platzierteTypen.Exists(o => o.Contains(kriterium)))
                pflichtErfüllt++;
        }

        // Bonus prüfen
        foreach (string kriterium in auftrag.bonusKriterien)
        {
            if (platzierteTypen.Exists(o => o.Contains(kriterium)))
                bonusErfüllt++;
        }

        bool pflichtOk = pflichtErfüllt >= auftrag.pflichtKriterien.Count;

        if (pflichtOk) auftrag.dekoriert = true;

        Debug.Log($"Dekoration abgeschlossen. Sterne: {(pflichtOk ? 1 : 0)} + {(bonusErfüllt > 0 ? 1 : 0)}");

        SceneManager.LoadScene("ComputerSzene");
    }
}
