using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public StoneClick StoneClick;

    public int copper;
    public int iron;
    public int Silver;
    public int gold;

    [SerializeField] private TextMeshProUGUI _copperText;
    [SerializeField] private TextMeshProUGUI _ironText;
    [SerializeField] private TextMeshProUGUI _SilverText;
    [SerializeField] private TextMeshProUGUI _goldText;



    void Start()
    {
        // データロード
    }

    public void Record()
    {
        switch (StoneClick.LotteryNumber)
        {
            case 1:
                copper++;
                Debug.Log("copper obtained! Total: " + copper);
                Display();
                break;
            case 2:
                iron++;
                Debug.Log("Iron obtained! Total: " + iron);
                Display();
                break;
            case 3:
                Silver++;
                Debug.Log("Silver obtained! Total: " + Silver);
                Display();
                break;
            case 4:
                gold++;
                Debug.Log("Gold obtained! Total: " + gold);
                Display();
                break;
            default:
                Debug.Log("アイテムなし");
                break;
        }
    }

    void Display()
    {
        _copperText.text = NumberFormatter.FormatNumber(copper);
        _ironText.text = NumberFormatter.FormatNumber(iron);
        _SilverText.text = NumberFormatter.FormatNumber(Silver);
        _goldText.text = NumberFormatter.FormatNumber(gold);
    }
}
