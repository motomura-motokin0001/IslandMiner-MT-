using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenSelect : MonoBehaviour
{
    public RectTransform targetObject;  // RectTransformに変更
    public Button selectButton;
    public Button closeButton;
    public Vector2 startPosition;
    public Vector2 closePosition;

    void Start()
    {
        // ボタンにクリックイベントを登録
        selectButton.onClick.AddListener(OnSelectButtonClick);
        closeButton.onClick.AddListener(OnCloseButtonClick);

        // targetObjectの初期位置に設定
        if (targetObject != null)
        {
            targetObject.anchoredPosition = startPosition;
        }
    }
    
    void OnSelectButtonClick()
    {
        // オブジェクトを選択したときの動作
        if (targetObject != null)
        {
            targetObject.anchoredPosition = closePosition;
        }
    }

    void OnCloseButtonClick()
    {
        // オブジェクトを閉じたときの動作
        if (targetObject != null)
        {
            targetObject.anchoredPosition = startPosition;
        }
    }
}
