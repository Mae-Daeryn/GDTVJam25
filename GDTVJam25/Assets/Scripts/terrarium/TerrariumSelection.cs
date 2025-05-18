//using System.Collections.Generic;
//using UnityEngine;

//public class TerrariumSelection : MonoBehaviour
//{
//    public GameObject terrariumButtonPrefab;
//    public Transform container;

//    private void Start()
//    {
//        for (int i = 0; i < 3; i++)
//        {
//            GameObject go = Instantiate(terrariumButtonPrefab, container);
//            TerrariumSlot slot = go.GetComponent<TerrariumSlot>();
//            slot.Init(i);

//            // Ordne erste freie Terrariennummer zu
//            Auftrag a = GameManager.Instance.alleAufträge.Find(x => x.angenommen && x.terrariumIndex < 0);
//            if (a != null)
//                a.terrariumIndex = i;
//        }
//    }
//}
