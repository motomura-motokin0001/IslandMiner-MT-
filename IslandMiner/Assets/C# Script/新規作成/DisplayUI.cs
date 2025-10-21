using UnityEngine;
using TMPro;

public class DisplayUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _CountText;

    [SerializeField] private TextMeshProUGUI _PlayTimeText;

    [SerializeField] private TextMeshProUGUI _copperText;
    [SerializeField] private TextMeshProUGUI _ironText;
    [SerializeField] private TextMeshProUGUI _SilverText;
    [SerializeField] private TextMeshProUGUI _goldText;

    void Start()
    {
        SaveSystem.Instance.LoadGame();
    }

    void Update()
    {
        Display();
    }
    
    public void Display()
    {
        _CountText.text = NumberFormatter.FormatNumber(SaveSystem.Instance.UserData.ClickCount);

        _PlayTimeText.text = NumberFormatter.FormatTime((int)SaveSystem.Instance.UserData.TotalTime);//TODO タイムを　日　時間　分　秒に変換するcodeに変える

        _copperText.text = NumberFormatter.FormatNumber(SaveSystem.Instance.UserData.Copper);
        _ironText.text = NumberFormatter.FormatNumber(SaveSystem.Instance.UserData.Iron);
        _SilverText.text = NumberFormatter.FormatNumber(SaveSystem.Instance.UserData.Silver);
        _goldText.text = NumberFormatter.FormatNumber(SaveSystem.Instance.UserData.Gold);
    }
}
