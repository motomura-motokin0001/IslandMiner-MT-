using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections.Generic;

public class ChangeMene : MonoBehaviour
{
    [Header("設定・統計・実績メニュー")]
    [SerializeField] private Button _SettingButton;
    [SerializeField] private Button _TotalButton;
    [SerializeField] private Button _AchievementButton;
    [SerializeField] private GameObject _SettingMene;
    [SerializeField] private GameObject _TotalMene;
    [SerializeField] private GameObject _AchievementMene;

    void Start()
    {
        _SettingButton.onClick.AddListener(SettingMene);
        _TotalButton.onClick.AddListener(TotalMene);
        _AchievementButton.onClick.AddListener(AchievementMeneMene);
        _SettingMene.SetActive(true);
        _TotalMene.SetActive(false);
        _AchievementMene.SetActive(false);
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
}
