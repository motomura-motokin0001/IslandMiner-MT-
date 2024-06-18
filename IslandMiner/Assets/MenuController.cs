using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MenuController : MonoBehaviour
{
    public RectTransform menuPanel;
    public Button menuButton;

    private bool isMenuVisible = false;
    public Vector3 hiddenPosition;
    public Vector3 visiblePosition;

    void Start()
    {
        // メニューを隠れた位置に設定
        menuPanel.anchoredPosition = hiddenPosition;

        // ボタンにクリックイベントを登録
        menuButton.onClick.AddListener(ToggleMenu);
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
}