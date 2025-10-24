using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections.Generic;

public class Pause_Mene : MonoBehaviour
{
    [Header("ポーズメニュー")]
    [SerializeField] private GameObject _PauseMene;
    [SerializeField] private List<Button> _PauseMeneButton;//オープン・クローズ
    private Vector3 _PauseMene_OpenScl = Vector3.one;
    private Vector3 _PauseMene_CloseScl = Vector3.zero;
    private bool _IsOpen = false;

    void Start()
    {
        _IsOpen = false;
        foreach (var button in _PauseMeneButton)
        {
            button.onClick.AddListener(PauseMene);
        }
        _PauseMene.transform.localScale = _PauseMene_CloseScl;
    }

    void PauseMene()
    {
        _IsOpen = !_IsOpen;
        switch (_IsOpen)
        {
            case true:
                _PauseMene.transform.DOScale(_PauseMene_OpenScl, 0.5f).SetEase(Ease.OutBack);
                break;
            case false:
                _PauseMene.transform.DOScale(_PauseMene_CloseScl, 0.5f).SetEase(Ease.InBack);
                break;
        }
        DebugLog();
    }

    void DebugLog()
    {
        if (_IsOpen)
        {
            Debug.Log("メニューを開");
        }
        else
        {
            Debug.Log("メニューを閉");
        }
        
    }
}
