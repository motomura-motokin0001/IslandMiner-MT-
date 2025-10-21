using System.IO;
using UnityEngine;

public class SaveSystem
{
    #region Singleton
    private static SaveSystem _instance = new SaveSystem();
    public static SaveSystem Instance => _instance;
    #endregion

    private SaveSystem() { LoadGame(); }

    public string Path => Application.dataPath + "/Data.json";
    
    public UserData UserData { get; private set; }

    public void SaveGame()
    {
        string jsonData = JsonUtility.ToJson(UserData);
        StreamWriter writer = new StreamWriter(Path, false);
        writer.WriteLine(jsonData);
        writer.Flush();
        writer.Close();
        Debug.Log($"セーブしました。\n=================\nユーザーネーム: {SaveSystem.Instance.UserData.UserName}\n最終セーブ日時: {SaveSystem.Instance.UserData.SaveDate}\n総プレイ時間: {NumberFormatter.FormatNumber(SaveSystem.Instance.UserData.ClickCount)}\n=================\n");
    }

    public void LoadGame()
    {
        if (!File.Exists(Path))
        {
            Debug.Log("<color = Red> セーブデータないよ </color>");
            UserData = new UserData();
            SaveGame();
            return;
        }

        StreamReader reader = new StreamReader(Path);
        string jsonData = reader.ReadToEnd();
        UserData = JsonUtility.FromJson<UserData>(jsonData);
        reader.Close();
    }
}
