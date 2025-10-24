using UnityEngine;
using TMPro;

public class DisplayUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _CountText;
    
    [SerializeField] private TextMeshProUGUI _T_CountText;
    [SerializeField] private TextMeshProUGUI _T_PlayTimeText;

    [SerializeField] private TextMeshProUGUI _copperText;
    [SerializeField] private TextMeshProUGUI _ironText;
    [SerializeField] private TextMeshProUGUI _SilverText;
    [SerializeField] private TextMeshProUGUI _goldText;



    void Update()
    {
        Display();
    }
    
    public void Display()
    {
        _CountText.text = NumberFormatter.FormatNumber(SaveSystem.Instance.UserData.ClickCount);

        _T_PlayTimeText.text = "遊んだ時間" + NumberFormatter.FormatTime((int)SaveSystem.Instance.UserData.TotalTime);

        _copperText.text = NumberFormatter.FormatNumber(SaveSystem.Instance.UserData.Copper);
        _ironText.text = NumberFormatter.FormatNumber(SaveSystem.Instance.UserData.Iron);
        _SilverText.text = NumberFormatter.FormatNumber(SaveSystem.Instance.UserData.Silver);
        _goldText.text = NumberFormatter.FormatNumber(SaveSystem.Instance.UserData.Gold);

        _T_CountText.text ="クリック回数  " + $"{SaveSystem.Instance.UserData.ClickCount}";
    }
}
