using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class changetext : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    private bool isStartText = true;
    public string Starttext;
    public string Changetext;

    // ボタンが押された時に呼び出されるメソッド
    public void OnButtonClick()
    {
        if (isStartText)
        {
            textMeshPro.text = Changetext ;
        }
        else
        {
            textMeshPro.text = Starttext;
        }
        isStartText = !isStartText;
    }
}
