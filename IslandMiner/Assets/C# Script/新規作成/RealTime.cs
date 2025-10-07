using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RealTime : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _RealTimeText;

    void Update()
    {
        //TODO 設定画面で現実時間を隠すオプションを追加する
        /*if (Escapism_Trigger) 
        {
            _RealTimeText.text = "????/??/?? ??:??:??";
        }*/
        _RealTimeText.text = ("本日の日付\n") + System.DateTime.Now.ToString("yyyy/MM/dd\nHH:mm:ss") ;
    }
}
