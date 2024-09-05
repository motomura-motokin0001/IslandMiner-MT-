using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections.Generic;

public class MenuController : MonoBehaviour
{
    public RectTransform menuPanel;
    public Button menuButton;
    public List<Button> otherButtons;  // 他のボタンのリストを追加

    private bool isMenuVisible = false;
    public Vector3 hiddenPosition;
    public Vector3 visiblePosition;

    void Start()
    {
        // メニューを隠れた位置に設定
        menuPanel.anchoredPosition = hiddenPosition;

        // ボタンにクリックイベントを登録
        menuButton.onClick.AddListener(ToggleMenu);

        // 他のボタンにクリックイベントを登録
        foreach (Button button in otherButtons)
        {
            button.onClick.AddListener(HideMenu);
        }
    }

    void ToggleMenu()
    {
        if (isMenuVisible)
        {
            // メニューを隠す
            menuPanel.DOAnchorPos(hiddenPosition, 0.5f);
        }
        else
        {
            // メニューを表示
            menuPanel.DOAnchorPos(visiblePosition, 0.5f);
        }
        isMenuVisible = !isMenuVisible;
    }

    void HideMenu()
    {
        if (isMenuVisible)
        {
            // メニューを隠す
            menuPanel.DOAnchorPos(hiddenPosition, 0.5f);
            isMenuVisible = false;
        }
    }
}
