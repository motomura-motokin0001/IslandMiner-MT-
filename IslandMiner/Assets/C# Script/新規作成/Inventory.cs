using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public StoneClick StoneClick;

    void Start()
    {
        SaveSystem.Instance.LoadGame();
    }

    public void Record()
    {
        switch (StoneClick.LotteryNumber)
        {
            case 1:
                SaveSystem.Instance.UserData.Copper++;
                Debug.Log("copper obtained! Total: " + SaveSystem.Instance.UserData.Copper);
                break;
            case 2:
                SaveSystem.Instance.UserData.Iron++;
                Debug.Log("Iron obtained! Total: " + SaveSystem.Instance.UserData.Iron);
                break;
            case 3:
                SaveSystem.Instance.UserData.Silver++;
                Debug.Log("Silver obtained! Total: " + SaveSystem.Instance.UserData.Silver);
                break;
            case 4:
                SaveSystem.Instance.UserData.Gold++;
                Debug.Log("Gold obtained! Total: " + SaveSystem.Instance.UserData.Gold);
                break;
            default:
                Debug.Log("アイテムなし");
                break;
        }
    }


}
