using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEditor;
using UnityEditor.UI;
using Unity.VisualScripting;

public class LoadsceneController : MonoBehaviour
{
    public RectTransform screenimage;
    public Button selectButton;

    private bool isMenuVisible = false;
    public Vector3 hiddenPosition;
    public Vector3 visiblePosition;
    public string Scenename;
    private DataManager dataManager;
    public bool  save_toggle = false;

    void Start()
    {
        dataManager = FindObjectOfType<DataManager>();
        // メニューを隠れた位置に設定
        screenimage.anchoredPosition = hiddenPosition;

        // ボタンにクリックイベントを登録
        selectButton.onClick.AddListener(Toggleimage);
    }

    void Toggleimage()
    {
        StartCoroutine(WaitAndUpdateCount()); // コルーチンを開始

        if (isMenuVisible)
        {
            // メニューを隠す
            screenimage.DOAnchorPos(hiddenPosition, 0.5f);
            
        }
        else
        {
            // メニューを表示
            screenimage.DOAnchorPos(visiblePosition, 0.5f);
        
        }
        isMenuVisible = !isMenuVisible;
        
    }
    IEnumerator WaitAndUpdateCount()
    {
        if(save_toggle == true)
        {
            dataManager.Save();
        }
        yield return new WaitForSeconds(2); // 2秒待機
        SceneManager.LoadScene(Scenename);
    }

}