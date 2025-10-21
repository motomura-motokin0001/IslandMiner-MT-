using UnityEngine;


[System.Serializable]
public class UserData
{/*==============基本データ==============*/
    public string UserName = "User";//ユーザー名

    public string SaveDate = "記録無し";//セーブ日時
    
    public float TotalTime = 0 ;//総プレイ時間

    public int ClickCount = 0 ;//クリック回数

    public int Money = 0 ;//所持金

    public int Copper = 0 ;//銅の所持数

    public int Iron = 0 ;//鉄の所持数

    public int Silver = 0 ;//銀の所持数

    public int Gold = 0;//金の所持数

    public int To_Town = 0;//町への行った回数

    /*=======================================*/

    /*==============アップグレードデータ==============*/

    public int Minor = 0;//ツルハシレベル

    /*===============================================*/
    /*==============その他==============*/

    public int AutoSave = 0;//ツルハシレベル

    /*===============================================*/
}
