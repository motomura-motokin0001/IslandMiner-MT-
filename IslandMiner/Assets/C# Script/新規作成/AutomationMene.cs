using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class AutomationMene : MonoBehaviour
{
    [Header("自動化メニュー 本体")]
    [SerializeField] private GameObject _AutomationMene;
    [Header("自動化メニュー ボタン")]
    [SerializeField] private Button _AutomationMeneButton;

    [Header("座標")]
    [SerializeField] private Vector3 _OpenPos;
    [SerializeField] private Vector3 _ClosePos;

    [Header("その他設定")]
    [SerializeField] private float _MoveTime = 0.5f;
    [SerializeField] private Ease _MoveEase_Open = Ease.Unset;
    [SerializeField] private Ease _MoveEase_Close = Ease.Unset;

    void Start()
    {
        _AutomationMeneButton.onClick.AddListener(OnClick_AutomationMeneButton);
    }
    void OnClick_AutomationMeneButton()
    {
        if (_AutomationMene.transform.localPosition == _ClosePos)
        {
            //メニューを開く
            _AutomationMene.transform.DOLocalMove(_OpenPos, _MoveTime).SetEase(_MoveEase_Open);
        }
        else if (_AutomationMene.transform.localPosition == _OpenPos)
        {
            //メニューを閉じる
            _AutomationMene.transform.DOLocalMove(_ClosePos, _MoveTime).SetEase(_MoveEase_Close);
        }   
        Debug.Log("自動化メニューを開閉");
    }
}
