using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DekoManager : MonoBehaviour
{
    public Transform platzierteObjekteParent;

    public void FertigDekoriert()
    {
        var auftrag = GameManager.Instance.aktiverAuftrag;

        int pflichtErf�llt = 0;
        int bonusErf�llt = 0;

        List<string> platzierteTypen = new List<string>();
        foreach (Transform child in platzierteObjekteParent)
        {
            var obj = child.GetComponent<PlatzierbareObjekt>();
            if (obj != null)
                platzierteTypen.Add(obj.objektTyp);
        }

        // Pflicht pr�fen
        foreach (string kriterium in auftrag.pflichtKriterien)
        {
            if (platzierteTypen.Exists(o => o.Contains(kriterium)))
                pflichtErf�llt++;
        }

        // Bonus pr�fen
        foreach (string kriterium in auftrag.bonusKriterien)
        {
            if (platzierteTypen.Exists(o => o.Contains(kriterium)))
                bonusErf�llt++;
        }

        bool pflichtOk = pflichtErf�llt >= auftrag.pflichtKriterien.Count;

        if (pflichtOk) auftrag.dekoriert = true;

        Debug.Log($"Dekoration abgeschlossen. Sterne: {(pflichtOk ? 1 : 0)} + {(bonusErf�llt > 0 ? 1 : 0)}");

        SceneManager.LoadScene("ComputerSzene");
    }
}
