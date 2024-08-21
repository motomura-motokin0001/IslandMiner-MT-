// using UnityEngine;
// using TMPro; // TextMeshProUGUIを使用するために追加
// using System.Collections.Generic;

// public class NumberDisplayController : MonoBehaviour
// {
//     // 複数のTextMeshProUGUIを表示するためのリスト
//     public TextMeshProUGUI numberTexts;

//     void Start()
//     {
//         // 初期値をテキストに設定
//         UpdateNumberText();
//     }

//     void Update()
//     {
//         // DataManagerのnumberを増加させる
//         DataManager.Instance.IncreaseNumber();
//         UpdateNumberText();
//     }

//     // 数値を複数のTextMeshProUGUIに更新するメソッド
//     void UpdateNumberText()
//     {
//         numberTexts.text = "Number: " + DataManager.Instance.number.ToString();
//     }
// }

