using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Animations;


public class SmallIsland_Cave_Click_Stone : MonoBehaviour
{
    public Button SCCS_Clickstone;
    public Button Stone_Enhancement;
    public Button Coal_Enhancement;
    public Button Iron_Enhancement;
    public Button Gold_Enhancement;
    public Text SCCS_countText;
    public TextMeshProUGUI Stone_CostText;
    public TextMeshProUGUI Coal_CostText;
    public TextMeshProUGUI Iron_CostText;
    public TextMeshProUGUI Gold_CostText;
    public TextMeshProUGUI Stonetext;
    public TextMeshProUGUI Coaltext;
    public TextMeshProUGUI Irontext;
    public TextMeshProUGUI Goldtext;

    private int  Randomnumbr = 0;


    void Start()
    {
        SCCS_Clickstone.onClick.AddListener(SCCS_IncrementCount);
        Stone_Enhancement.onClick.AddListener(SE);
        Coal_Enhancement.onClick.AddListener(CE);
        Iron_Enhancement.onClick.AddListener(IE);
        Gold_Enhancement.onClick.AddListener(GE);
        
        SCCS_UpdateCountText();
    }
    void SCCS_RandomNB()
    {
        Randomnumbr = Random.Range(1,5);
        Debug.Log(Randomnumbr);
    }


    public void SCCS_IncrementCount()
    {
        DataManager.Instance.SmallIslandCave_Stone_count++; 
        SCCS_UpdateCountText();
        SCCS_RandomNB();
    }

    void SCCS_UpdateCountText()
    {
        SCCS_countText.text = DataManager.Instance.SmallIslandCave_Stone_count.ToString() + "回"; 
    }

    void Update()
    {
        Stonetext.text = DataManager.Instance.Stone.ToString();
        Coaltext.text = DataManager.Instance.Coal.ToString();
        Irontext.text = DataManager.Instance.Iron.ToString();
        Goldtext.text = DataManager.Instance.Gold.ToString();
        Stone_CostText.text = "cost" + DataManager.Instance.Stone_Cost.ToString();
        Coal_CostText.text = "cost" + DataManager.Instance.Coal_Cost.ToString();
        Iron_CostText.text = "cost" + DataManager.Instance.Iron_Cost.ToString();
        Gold_CostText.text = "cost" + DataManager.Instance.Gold_Cost.ToString();


        if (Randomnumbr == 1)
        {
            int newStoneValue = DataManager.Instance.Stone + DataManager.Instance.StonePT;
            DataManager.Instance.Stone = newStoneValue;
            Stonetext.text = newStoneValue.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 2)
        {
            int newCoalValue = DataManager.Instance.Coal + DataManager.Instance.CoalPT;
            DataManager.Instance.Coal = newCoalValue;
            Coaltext.text = newCoalValue.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 3)
        {
            int newIronValue = DataManager.Instance.Iron + DataManager.Instance.IronPT;
            DataManager.Instance.Iron = newIronValue;
            Irontext.text = newIronValue.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 4)
        {
            int newGoldValue = DataManager.Instance.Gold + DataManager.Instance.GoldPT;
            DataManager.Instance.Gold = newGoldValue;
            Goldtext.text = newGoldValue.ToString();
            Randomnumbr = 0;
        }
    }

    public void SE()
    {
        if(DataManager.Instance.Stone_Cost <= DataManager.Instance.Stone)
        {
            DataManager.Instance.Stone = DataManager.Instance.Stone - DataManager.Instance.Stone_Cost;
            DataManager.Instance.StonePT = DataManager.Instance.StonePT + 1;
            DataManager.Instance.Stone_Cost = DataManager.Instance.Stone_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 

    public void CE()
    {
        if(DataManager.Instance.Coal_Cost <= DataManager.Instance.Coal)
        {
            DataManager.Instance.Coal = DataManager.Instance.Coal - DataManager.Instance.Coal_Cost;
            DataManager.Instance.CoalPT = DataManager.Instance.CoalPT + 1;
            DataManager.Instance.Coal_Cost = DataManager.Instance.Coal_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 

    public void IE()
    {
        if(DataManager.Instance.Iron_Cost <= DataManager.Instance.Iron)
        {
            DataManager.Instance.Iron =  DataManager.Instance.Iron- DataManager.Instance.Iron_Cost;
            DataManager.Instance.IronPT = DataManager.Instance.IronPT + 1;
            DataManager.Instance.Iron_Cost = DataManager.Instance.Iron_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 

    public void GE()
    {
        if(DataManager.Instance.Gold_Cost <= DataManager.Instance.Gold)
        {
            DataManager.Instance.Gold = DataManager.Instance.Gold - DataManager.Instance.Gold_Cost ;
            DataManager.Instance.GoldPT = DataManager.Instance.GoldPT + 1;
            DataManager.Instance.Gold_Cost = DataManager.Instance.Gold_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 
}

