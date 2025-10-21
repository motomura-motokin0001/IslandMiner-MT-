using UnityEngine;

public class SaveTest : MonoBehaviour
{
    public Inventory Inventory;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveSystem.Instance.SaveGame();
            SaveSystem.Instance.UserData.SaveDate = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            SaveLog();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            SaveSystem.Instance.LoadGame();
            Debug.Log("Load");

        }
    }

    void SaveLog()
    {
        Debug.Log($"セーブしました。\n=================\nユーザーネーム: {SaveSystem.Instance.UserData.UserName}\n最終セーブ日時: {SaveSystem.Instance.UserData.SaveDate}\n総プレイ時間: {NumberFormatter.FormatNumber(SaveSystem.Instance.UserData.ClickCount)}\n=================\n");
    }

}
