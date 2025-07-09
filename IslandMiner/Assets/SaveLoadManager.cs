using CI.QuickSave;
using UnityEngine;

public class SaveLoadManager : MonoBehaviour
{
    // 保存するデータ
    private GameData gameData = new GameData();
    private const string saveKey = "gameData"; // セーブデータのキー

    void Start()
    {
        // ゲーム開始時にデータをロード
        LoadGame();
    }

    // セーブ処理
    public void SaveGame()
    {
        try
        {
            // ゲームデータを保存
            QuickSaveWriter.Create(saveKey).Write(saveKey, gameData);
            Debug.Log("ゲームデータが保存されました！");
            
        }
        catch (System.Exception ex)
        {
            Debug.LogError("セーブ中にエラーが発生しました: " + ex.Message);
        }
    }

    // ロード処理
    public void LoadGame()
    {
        try
        {
            // セーブデータが存在すれば、ゲームデータを読み込む
            if (QuickSaveReader.Create(saveKey).Exists(saveKey))
            {
                gameData = QuickSaveReader.Create(saveKey).Read<GameData>(saveKey);
                Debug.Log("ゲームデータが読み込まれました！");
            }
            else
            {
                Debug.Log("セーブデータが存在しません。");
                // デフォルト値を設定する処理もここに追加できます
            }
        }
        catch (System.Exception ex)
        {
            Debug.LogError("ロード中にエラーが発生しました: " + ex.Message);
        }
    }
}
