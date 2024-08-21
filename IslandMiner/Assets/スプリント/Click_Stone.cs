using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Click_Stone : MonoBehaviour
{
    public Button Clickstone; // ボタンの参照
    public Text countText; // カウント表示用テキストの参照
    public TextMeshProUGUI stonetext;
    public TextMeshProUGUI coaltext;
    public TextMeshProUGUI irontext;
    public TextMeshProUGUI goldtext;


    private int count = 0; 
    public int  Randomnumbr = 0;
    public int stone= 0;
    public int coal = 0;
    public int iron = 0;
    public int gold = 0;
    

    void Start()
    {
        // ボタンにクリックイベントリスナーを追加
        Clickstone.onClick.AddListener(IncrementCount);
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
            DataManager.Instance.stone++;
            stonetext.text = DataManager.Instance.stone.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 2)
        {
            DataManager.Instance.coal++;
            coaltext.text = DataManager.Instance.coal.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 3)
        {
            DataManager.Instance.iron++;
            irontext.text = DataManager.Instance.iron.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 4)
        {
            DataManager.Instance.gold++;
            goldtext.text = DataManager.Instance.gold.ToString();
            Randomnumbr = 0;
        }
    }
}