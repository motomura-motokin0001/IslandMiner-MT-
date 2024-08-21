using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Click_Stone : MonoBehaviour
{
    public Button stone; // ボタンの参照
    public Text countText; // カウント表示用テキストの参照
    public TextMeshProUGUI oretext1;
    public TextMeshProUGUI oretext2;
    public TextMeshProUGUI oretext3;
    public TextMeshProUGUI oretext4;
    public List<TextMeshProUGUI> one1texts;

    private int count = 0; // カウント変数
    private int ore1 = 0;
    private int ore2 = 0;
    private int ore3 = 0;
    private int ore4 = 0;
    private int  Randomnumbr = 0;

    void Start()
    {
        // ボタンにクリックイベントリスナーを追加
        stone.onClick.AddListener(IncrementCount);
        // 初期カウント表示
        UpdateCountText();
        
    }
    void RandomNB()
    {
        Randomnumbr = Random.Range(1,5);
        Debug.Log(Randomnumbr);
    }


    void IncrementCount()
    {
        count++; // カウントを増加
        UpdateCountText(); // カウント表示を更新
        RandomNB();
    }

    void UpdateCountText()
    {
        countText.text = count.ToString() + "回"; // カウントをテキストに設定
    }

    void Update()
    {
        if (Randomnumbr == 1)
        {
            ore1++;
            oretext1.text = ore1.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 2)
        {
            ore2++;
            oretext2.text = ore2.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 3)
        {
            ore3++;
            oretext3.text = ore3.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 4)
        {
            ore4++;
            oretext4.text = ore4.ToString();
            Randomnumbr = 0;
        }
    }
}