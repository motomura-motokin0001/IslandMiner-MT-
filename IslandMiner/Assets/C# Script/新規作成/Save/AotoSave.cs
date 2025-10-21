using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements.Experimental;
using TMPro;

public class AutoSave : MonoBehaviour
{
    [SerializeField] TMP_Dropdown _TimeDropdown;
    private float _TimeLimit;
    private float _time;
    [SerializeField] private string _Debag_value;

public static AutoSave Instance;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        // シーン切り替えイベント登録
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Titleシーンなら破棄
        if (scene.name == "Title")
        {
            Destroy(gameObject);
        }
    }

    void OnDestroy()
    {
        // イベント登録解除（メモリリーク防止）
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }


    void Start()
    {
        // Dropdownが設定されていれば、イベント登録
        if (_TimeDropdown != null)
        {
            _TimeDropdown.onValueChanged.AddListener(ChangeTime);
            _TimeDropdown.value = SaveSystem.Instance.UserData.AutoSave;
            ChangeTime(SaveSystem.Instance.UserData.AutoSave); // 初期値も反映
        }
    }

    void Update()
    {
        _time += Time.deltaTime;

        if (_time >= _TimeLimit)
        {
            SaveSystem.Instance.SaveGame();
            _time = 0;
        }
        _Debag_value = NumberFormatter.FormatTime((int)_time).ToString();
    }
    
    public void ChangeTime(int value)
    {
        // valueに応じてセーブ間隔を設定（秒）
        switch (value)
        {
            case 0:
                _TimeLimit = 0;      // 無効
                break;
            case 1:
                _TimeLimit = 60;    // 1分
                break;
            case 2:
                _TimeLimit = 600;   // 10分
                break;
            case 3:
                _TimeLimit = 900;   // 15分
                break;
            case 4:
                _TimeLimit = 1800;  // 30分
                break;
            case 5:
                _TimeLimit = 3600;  // 60分
                break;
        }
        SaveSystem.Instance.UserData.AutoSave = value;
        SaveSystem.Instance.SaveGame();
        _time = 0;
        Debug.Log($"オートセーブ間隔を {_TimeLimit} 秒に設定");
    }
}
