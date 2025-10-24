using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections.Generic;
using NUnit.Framework;

public class SideMene : MonoBehaviour
{
    [SerializeField] private string info;
    [Header("自動化メニュー")]
    [SerializeField] private GameObject _TargetMene;
    [SerializeField] private Button _TargetButton;
    [SerializeField] private Vector3 _OpenPos;
    [SerializeField] private Vector3 _ClosePos;
    [SerializeField] private float _MoveTime = 0.5f;
    [SerializeField] private Ease _MoveEase_Open = Ease.Unset;
    [SerializeField] private Ease _MoveEase_Close = Ease.Unset;
    private bool IsMene;

    void Start()
    {
        _TargetButton.onClick.AddListener(OnClick__TargetMeneButton);
        IsMene = false;
    }

    void OnClick__TargetMeneButton()
    {
        IsMene = !IsMene;
        if (IsMene)
        {
            _TargetMene.transform.DOLocalMove(_OpenPos, _MoveTime).SetEase(_MoveEase_Open);
        }
        else
        {
            _TargetMene.transform.DOLocalMove(_ClosePos, _MoveTime).SetEase(_MoveEase_Close);
        }
        DebugLog();
    }

    void DebugLog()
    {
        if (IsMene)
        {
            Debug.Log("メニューを開");
        }
        else
        {
            Debug.Log("メニューを閉");
        }
        
    }
}
