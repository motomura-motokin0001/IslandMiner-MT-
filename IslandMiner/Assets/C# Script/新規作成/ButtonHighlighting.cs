using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

    //このスクリプトは、ボタンをホバーしたときに拡大表示・押されたら縮小するするためのものです。

public class ButtonHighlighting : MonoBehaviour
{
    [SerializeField] private List<Button> _buttons = new List<Button>();
    [SerializeField] private Vector3 _highlightScale = new Vector3(1.2f, 1.2f, 1.2f);
    [SerializeField] private Ease _easeType = Ease.OutBack;
    private Vector3 _originalScale = Vector3.one;

    void Update()
    {
        foreach (var button in _buttons)
        {
            RectTransform rectTransform = button.GetComponent<RectTransform>();
            Vector2 localMousePosition = rectTransform.InverseTransformPoint(Input.mousePosition);
            bool isHovering = rectTransform.rect.Contains(localMousePosition);

            if (isHovering)
            {
                // ホバーしている場合、拡大表示
                rectTransform.DOScale(_highlightScale, 0.2f).SetEase(_easeType);
            }
            else
            {
                // ホバーしていない場合、元のサイズに戻す
                rectTransform.DOScale(_originalScale, 0.2f).SetEase(_easeType);
            }
            if (Input.GetMouseButtonDown(0) && isHovering)
            {
                // ボタンが押された場合、縮小表示
                isHovering = false; // 押されたらホバー状態を解除
                rectTransform.DOScale(_originalScale * 0.9f, 0.1f).SetEase(_easeType).OnComplete(() =>
                {
                    // 縮小表示が完了したら元のサイズに戻す
                    rectTransform.DOScale(_highlightScale, 5f).SetEase(_easeType);
                    isHovering = true; // ホバー状態を再度有効にする
                });
            }
        }
    }

}