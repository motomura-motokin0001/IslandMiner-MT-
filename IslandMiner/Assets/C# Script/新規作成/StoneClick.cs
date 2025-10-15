using UnityEngine;
using UnityEngine.UI;

public class StoneClick : MonoBehaviour
{
    public Inventory Inventory;

    [SerializeField] Button _storeButton;
    public int LotteryNumber = 0;

    void Start()
    {
        _storeButton.onClick.AddListener(OnStoneButtonClick);
    }

    void OnStoneButtonClick()
    {
        Debug.Log("Store button clicked!");
        LotteryNumber = Random.Range(1, 5);
        Debug.Log("Random number: " + LotteryNumber);
        Inventory.Record();
    }
}
