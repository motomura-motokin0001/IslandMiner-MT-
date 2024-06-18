using UnityEngine;
using UnityEngine.UI;

public class ButtonCounter : MonoBehaviour
{
    public Button stone; // ボタンの参照
    public Text countText; // カウント表示用テキストの参照
    private int count = 0; // カウント変数

    void Start()
    {
        // ボタンにクリックイベントリスナーを追加
        stone.onClick.AddListener(IncrementCount);
        // 初期カウント表示
        UpdateCountText();
    }

    void IncrementCount()
    {
        count++; // カウントを増加
        UpdateCountText(); // カウント表示を更新
    }

    void UpdateCountText()
    {
        countText.text = count.ToString() + "回"; // カウントをテキストに設定
    }
}
