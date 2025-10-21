using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RealTime : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _RealTimeText;
    [SerializeField] private Toggle _EscapismToggle;
    [SerializeField] private int _playCount;

    public static RealTime Instance { get; private set; }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        PlayTime();
        if (_EscapismToggle.isOn == true)
        {
            _RealTimeText.text = "本日の日付\n" + "????/??/??\n??:??:??";
        }
        else
        {
            _RealTimeText.text = "本日の日付\n" + System.DateTime.Now.ToString("yyyy/MM/dd\nHH:mm:ss");
        }
    }

    void PlayTime()
    {
        SaveSystem.Instance.UserData.TotalTime  += Time.deltaTime;
    }
}
