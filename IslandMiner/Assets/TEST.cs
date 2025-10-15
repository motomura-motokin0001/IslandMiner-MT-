using UnityEngine;
using TMPro;

public class TEST : MonoBehaviour
{
    public TextMeshProUGUI CoutText;
    public void K()
    {
        Debug.Log("押された");
    }

    void Update()
    {
        long count = 0;
        //0.2秒ごとにカウントアップ
        count = (int)(Time.time * 2000);
        
        CoutText.text = NumberFormatter.FormatNumber(count);
    }
}
