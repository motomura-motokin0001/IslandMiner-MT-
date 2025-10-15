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

    void Start()
    {
        _Mene_Scl = true;
        try //ポーズメニューが存在するか
        {
            foreach(var button in _PauseMeneButton)
            {
                button.onClick.AddListener(PauseMene);
            }
            _PauseMene.transform.localScale = _PauseMene_CloseScl;
        }
        catch
        {
            Debug.Log("ポーズメニューが存在しません");
        }
    }


    void PauseMene()
    {
        switch(_Mene_Scl)
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
}
