using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections.Generic;

public class MeneSystem : MonoBehaviour
{
    [Header("ポーズメニュー")]
    [SerializeField] private GameObject _PauseMene;
    [SerializeField] private List<Button> _PauseMeneButton;
    private Vector3 _PauseMene_OpenScl = Vector3.one;
    private Vector3 _PauseMene_CloseScl = Vector3.zero;
    private bool _Mene_Scl = true;

    [Header("設定・統計・実績メニュー")]
    [SerializeField] private Button _SettingButton;
    [SerializeField] private Button _TotalButton;
    [SerializeField] private Button _AchievementButton;
    [SerializeField] private GameObject _SettingMene;
    [SerializeField] private GameObject _TotalMene;
    [SerializeField] private GameObject _AchievementMene;

    [Header("自動化メニュー")]
    [SerializeField] private GameObject _AutomationMene;
    [SerializeField] private Button _AutomationMeneButton;
    [SerializeField] private Vector3 _OpenPos;
    [SerializeField] private Vector3 _ClosePos;
    [SerializeField] private float _MoveTime = 0.5f;
    [SerializeField] private Ease _MoveEase_Open = Ease.Unset;
    [SerializeField] private Ease _MoveEase_Close = Ease.Unset;

    [Header("町一覧メニュー")]
    [SerializeField] private GameObject _TownListMene;
    [SerializeField] private Button _TownListMeneButton;
    [SerializeField] private Vector3 _Town_OpenPos;
    [SerializeField] private Vector3 _Town_ClosePos;
    [SerializeField] private float _Town_MoveTime_ = 0.5f;
    [SerializeField] private Ease _Town_MoveEase_Open = Ease.Unset;
    [SerializeField] private Ease _Town_MoveEase_Close = Ease.Unset;
    [SerializeField] private List<Button> _TownListButton;

    void Start()
    {
        _Mene_Scl = true;

        foreach (var button in _PauseMeneButton)
        {
            button.onClick.AddListener(PauseMene);
        }
        _PauseMene.transform.localScale = _PauseMene_CloseScl;

        _SettingButton.onClick.AddListener(SettingMene);
        _TotalButton.onClick.AddListener(TotalMene);
        _AchievementButton.onClick.AddListener(AchievementMeneMene);

        _SettingMene.SetActive(true);
        _TotalMene.SetActive(false);
        _AchievementMene.SetActive(false);

        _AutomationMeneButton.onClick.AddListener(OnClick_AutomationMeneButton);

        _TownListMeneButton.onClick.AddListener(OnClick_TownMeneButton);
        foreach (var button in _TownListButton)
        {
            button.onClick.AddListener(OnClick_TownMeneButton);
        }

    }


    void PauseMene()
    {
        switch (_Mene_Scl)
        {
            case true:
                //メニューを開く
                Debug.Log("true");
                _PauseMene.transform.DOScale(_PauseMene_OpenScl, 0.5f).SetEase(Ease.OutBack);
                _Mene_Scl = false;
                break;
            case false:
                //メニューを閉じる
                Debug.Log("false");
                _PauseMene.transform.DOScale(_PauseMene_CloseScl, 0.5f).SetEase(Ease.InBack);
                _Mene_Scl = true;
                break;
        }
        Debug.Log("ポーズメニューを開閉");
    }

    void SettingMene()
    {
        _SettingMene.SetActive(true);
        _TotalMene.SetActive(false);
        _AchievementMene.SetActive(false);
        Debug.Log("設定メニューを開く");
    }
    void TotalMene()
    {
        _SettingMene.SetActive(false);
        _TotalMene.SetActive(true);
        _AchievementMene.SetActive(false);
        Debug.Log("統計メニューを開く");
    }
    void AchievementMeneMene()
    {
        _SettingMene.SetActive(false);
        _TotalMene.SetActive(false);
        _AchievementMene.SetActive(true);
        Debug.Log("実績メニューを開く");
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

    void OnClick_TownMeneButton()
    {
        if (_TownListMene.transform.localPosition == _Town_ClosePos)
        {
            //メニューを開く
            _TownListMene.transform.DOLocalMove(_Town_OpenPos, _Town_MoveTime_).SetEase(_Town_MoveEase_Open);
        }
        else if (_TownListMene.transform.localPosition == _Town_OpenPos)
        {
            //メニューを閉じる
            _TownListMene.transform.DOLocalMove(_Town_ClosePos, _Town_MoveTime_).SetEase(_Town_MoveEase_Close);
        }
        Debug.Log("町一覧メニューを開閉");
    }

    void OnClick_TownListMeneButton()
    {
        
    }
}
