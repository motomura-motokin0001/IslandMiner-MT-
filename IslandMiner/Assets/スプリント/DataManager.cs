using UnityEngine;

public class DataManager : MonoBehaviour
{
    // シングルトンインスタンス
    public static DataManager Instance { get; private set; }

    // 共有する数値データ

    public int coin = 0;
    public int stone = 0;
    public int iron = 0;
    public int coal = 0;
    public int gold = 0;
    public int Bloodstone = 0;
    public int copper = 0;









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

}
