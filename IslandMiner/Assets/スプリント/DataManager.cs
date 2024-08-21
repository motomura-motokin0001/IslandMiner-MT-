using UnityEngine;

public class DataManager : MonoBehaviour
{
    // シングルトンインスタンス
    public static DataManager Instance { get; private set; }

    // 共有する数値データ
    public int number = 0;

    void Awake()
    {
        // インスタンスがすでに存在する場合、現在のオブジェクトを破棄する
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // シーンが切り替わってもオブジェクトを破棄しない
        }
    }

    // 数値を増加させるメソッド
    public void IncreaseNumber()
    {
        number++;
    }
}
