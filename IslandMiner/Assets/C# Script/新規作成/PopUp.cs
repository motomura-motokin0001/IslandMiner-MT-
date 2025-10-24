using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
    [SerializeField] private GameObject _PopUpMene;
    [SerializeField] private Button _OpenButton;
    [SerializeField] private Button _ReturnButton;
    [SerializeField] private Button _LeftButton;
    [SerializeField] private Button _RightButton;
    [SerializeField] private float _Time;
    [SerializeField] private UnityEvent _onClick_LeftButton;
    [SerializeField] private UnityEvent _onClick_RightButton;
    private Vector3 _Open = new Vector3(1, 1, 1);
    private Vector3 _close = new Vector3(1, 0, 1);
    void Start()
    {
        _PopUpMene.transform.localScale = _close;
        _ReturnButton.onClick.AddListener(ClosePopUp);
        _OpenButton.onClick.AddListener(OpenPopUp);
        _RightButton.onClick.AddListener(RightButton);
        _LeftButton.onClick.AddListener(LeftButton);
    }

    void OpenPopUp()
    {
        _PopUpMene.transform.DOScale(_Open, _Time);
    }
    void ClosePopUp()
    {
        _PopUpMene.transform.DOScale(_close, _Time);
    }

    void LeftButton()
    {
        _onClick_LeftButton.Invoke(); 
    }

    void RightButton()
    {
        _onClick_RightButton.Invoke(); 
    }
}
