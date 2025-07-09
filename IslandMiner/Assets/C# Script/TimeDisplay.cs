using UnityEngine;
using TMPro;  // TextMeshProを使用するための名前空間

public class TimeDisplay : MonoBehaviour
{
    // TextMeshProUGUIコンポーネントを参照するための変数
    public TextMeshProUGUI YMD_Hm_Text;

    void Update()
    {
        // 現在の日付と時間を取得
        string currentDateTime = System.DateTime.Now.ToString("yyyy/MM/dd (ddd) HH:mm");
        
        // 日付と時間をTextMeshProのテキストに表示
        YMD_Hm_Text.text = currentDateTime;
    }
}
