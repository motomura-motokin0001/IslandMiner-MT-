using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Animations;


public class SmallIsland_Cave_Click_Stone : MonoBehaviour
{

    public TextMeshProUGUI SCCS_countText;
    public TextMeshProUGUI Stone_CostText;
    public TextMeshProUGUI Coal_CostText;
    public TextMeshProUGUI Iron_CostText;
    public TextMeshProUGUI Gold_CostText;
    public TextMeshProUGUI Stonetext;
    public TextMeshProUGUI Coaltext;
    public TextMeshProUGUI Irontext;
    public TextMeshProUGUI Goldtext;

    private int  Randomnumbr = 0;

void Awake()
{
    if (Stonetext == null) Debug.LogError("Stonetext が設定されていません！");
    if (Coaltext == null) Debug.LogError("Coaltext が設定されていません！");
    if (Irontext == null) Debug.LogError("Irontext が設定されていません！");
    if (Goldtext == null) Debug.LogError("Goldtext が設定されていません！");
    if (Stone_CostText == null) Debug.LogError("Stone_CostText が設定されていません！");
    if (Coal_CostText == null) Debug.LogError("Coal_CostText が設定されていません！");
    if (Iron_CostText == null) Debug.LogError("Iron_CostText が設定されていません！");
    if (Gold_CostText == null) Debug.LogError("Gold_CostText が設定されていません！");
        if (SCCS_countText == null)
    {
        Debug.LogError("countText が Inspector で設定されていません！");
    }
}
    void Start()
    {

        SCCS_UpdateCountText();
    }
    void SCCS_RandomNB()
    {
        Randomnumbr = Random.Range(1,5);
        Debug.Log(Randomnumbr);
    }


    public void SCCS_IncrementCount()
    {
        GameData.Instance.SmallIslandCave_Stone_count++; 
        SCCS_UpdateCountText();
        SCCS_RandomNB();
    }

    void SCCS_UpdateCountText()
    {
            if (SCCS_countText == null)
    {
        Debug.LogError("countText が設定されていません！");
        return;
    }
        SCCS_countText.text = GameData.Instance.SmallIslandCave_Stone_count.ToString() ; 
    }

    void Update()
    {
        Stonetext.text = GameData.Instance.Stone.ToString();
        Coaltext.text = GameData.Instance.Coal.ToString();
        Irontext.text = GameData.Instance.Iron.ToString();
        Goldtext.text = GameData.Instance.Gold.ToString();
        Stone_CostText.text = "cost" + GameData.Instance.Stone_Cost.ToString();
        Coal_CostText.text = "cost" + GameData.Instance.Coal_Cost.ToString();
        Iron_CostText.text = "cost" + GameData.Instance.Iron_Cost.ToString();
        Gold_CostText.text = "cost" + GameData.Instance.Gold_Cost.ToString();


        if (Randomnumbr == 1)
        {
            int newStoneValue = GameData.Instance.Stone + GameData.Instance.StonePT;
            GameData.Instance.Stone = newStoneValue;
            Stonetext.text = newStoneValue.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 2)
        {
            int newCoalValue = GameData.Instance.Coal + GameData.Instance.CoalPT;
            GameData.Instance.Coal = newCoalValue;
            Coaltext.text = newCoalValue.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 3)
        {
            int newIronValue = GameData.Instance.Iron + GameData.Instance.IronPT;
            GameData.Instance.Iron = newIronValue;
            Irontext.text = newIronValue.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 4)
        {
            int newGoldValue = GameData.Instance.Gold + GameData.Instance.GoldPT;
            GameData.Instance.Gold = newGoldValue;
            Goldtext.text = newGoldValue.ToString();
            Randomnumbr = 0;
        }
    }

    public void SE()
    {
        if(GameData.Instance.Stone_Cost <= GameData.Instance.Stone)
        {
            GameData.Instance.Stone = GameData.Instance.Stone - GameData.Instance.Stone_Cost;
            GameData.Instance.StonePT = GameData.Instance.StonePT + 1;
            GameData.Instance.Stone_Cost = GameData.Instance.Stone_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 

    public void CE()
    {
        if(GameData.Instance.Coal_Cost <= GameData.Instance.Coal)
        {
            GameData.Instance.Coal = GameData.Instance.Coal - GameData.Instance.Coal_Cost;
            GameData.Instance.CoalPT = GameData.Instance.CoalPT + 1;
            GameData.Instance.Coal_Cost = GameData.Instance.Coal_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 

    public void IE()
    {
        if(GameData.Instance.Iron_Cost <= GameData.Instance.Iron)
        {
            GameData.Instance.Iron =  GameData.Instance.Iron- GameData.Instance.Iron_Cost;
            GameData.Instance.IronPT = GameData.Instance.IronPT + 1;
            GameData.Instance.Iron_Cost = GameData.Instance.Iron_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 

    public void GE()
    {
        if(GameData.Instance.Gold_Cost <= GameData.Instance.Gold)
        {
            GameData.Instance.Gold = GameData.Instance.Gold - GameData.Instance.Gold_Cost ;
            GameData.Instance.GoldPT = GameData.Instance.GoldPT + 1;
            GameData.Instance.Gold_Cost = GameData.Instance.Gold_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 
}

