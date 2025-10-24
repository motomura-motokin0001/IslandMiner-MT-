using UnityEngine;

public class ManualSave_Load : MonoBehaviour
{
    public void ManualSave()
    {
        SaveSystem.Instance.SaveGame();
        SaveLog();
    }

    public void ManualLoad()
    {
        SaveSystem.Instance.LoadGame();
        Debug.Log("ロードしました。");
    }



    void SaveLog()
    {
        Debug.Log($"セーブしました。\n=================\nユーザーネーム: {SaveSystem.Instance.UserData.UserName}\n最終セーブ日時: {SaveSystem.Instance.UserData.SaveDate}\n総プレイ時間: {NumberFormatter.FormatNumber(SaveSystem.Instance.UserData.ClickCount)}\n=================\n");
    }

}
