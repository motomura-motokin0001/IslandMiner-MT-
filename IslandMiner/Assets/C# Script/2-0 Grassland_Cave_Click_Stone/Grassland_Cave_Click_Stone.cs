using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Animations;


public class Grassland_Cave_Click_Stone : MonoBehaviour
{
    public Button GCCS_Clickstone;
    public Button Bloodstone_Enhancement;
    public Button Copper_Enhancement;
    public Button jade_Enhancement;
    public Button Topaz_Enhancement;
    public Text GCS_countText;
    public TextMeshProUGUI Bloodstone_CostText;
    public TextMeshProUGUI Copper_CostText;
    public TextMeshProUGUI jade_CostText;
    public TextMeshProUGUI Topaz_CostText;
    public TextMeshProUGUI Bloodstonetext;
    public TextMeshProUGUI Coppertext;
    public TextMeshProUGUI jadetext;
    public TextMeshProUGUI Topaztext;

    private int  Randomnumbr = 0;

    void Start()
    {
        GCCS_Clickstone.onClick.AddListener(GCCS_IncrementCount);
        Bloodstone_Enhancement.onClick.AddListener(BE);
        Copper_Enhancement.onClick.AddListener(CoE);
        jade_Enhancement.onClick.AddListener(JE);
        Topaz_Enhancement.onClick.AddListener(TE);
        
        GCCS_UpdateCountText();
    }
    void GTS_RandomNB()
    {
        Randomnumbr = Random.Range(1,5);
        Debug.Log(Randomnumbr);
    }


    void GCCS_IncrementCount()
    {
        DataManager.Instance.Grassland_Click_Stone_count++;
        GCCS_UpdateCountText();
        GTS_RandomNB();
    }

    void GCCS_UpdateCountText()
    {
        GCS_countText.text = DataManager.Instance.Grassland_Click_Stone_count.ToString() + "回";
    }

    void Update()
    {
        Bloodstonetext.text = DataManager.Instance.Bloodstone.ToString();
        Coppertext.text = DataManager.Instance.Copper.ToString();
        jadetext.text = DataManager.Instance.jade.ToString();
        Topaztext.text = DataManager.Instance.Topaz.ToString();
        Bloodstone_CostText.text = "cost" + DataManager.Instance.Bloodstone.ToString();
        Copper_CostText.text = "cost" + DataManager.Instance.Coal_Cost.ToString();
        jade_CostText.text = "cost" + DataManager.Instance.jade_Cost.ToString();
        Topaz_CostText.text = "cost" + DataManager.Instance.Topaz_Cost.ToString();

        if (Randomnumbr == 1)
        {
            int newBloodstoneValue = DataManager.Instance.Bloodstone + DataManager.Instance.BloodstonePT;
            DataManager.Instance.Bloodstone = newBloodstoneValue;
            Bloodstonetext.text = newBloodstoneValue.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 2)
        {
            int newCopperValue = DataManager.Instance.Copper + DataManager.Instance.CopperPT;
            DataManager.Instance.Copper = newCopperValue;
            Coppertext.text = newCopperValue.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 3)
        {
            int newjadeValue = DataManager.Instance.jade + DataManager.Instance.jadePT;
            DataManager.Instance.jade = newjadeValue;
            jadetext.text = newjadeValue.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 4)
        {
            int newTopazValue = DataManager.Instance.Topaz + DataManager.Instance.TopazPT;
            DataManager.Instance.Topaz = newTopazValue;
            Topaztext.text = newTopazValue.ToString();
            Randomnumbr = 0;
        }
    }

    public void BE()
    {
        if(DataManager.Instance.Bloodstone_Cost <= DataManager.Instance.Bloodstone)
        {
            DataManager.Instance.Bloodstone = DataManager.Instance.Bloodstone - DataManager.Instance.Bloodstone_Cost;
            DataManager.Instance.BloodstonePT = DataManager.Instance.BloodstonePT + 1;
            DataManager.Instance.Bloodstone_Cost = DataManager.Instance.Bloodstone_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 

    public void CoE()
    {
        if(DataManager.Instance.Copper_Cost <= DataManager.Instance.Copper)
        {
            DataManager.Instance.Copper = DataManager.Instance.Copper - DataManager.Instance.Copper_Cost;
            DataManager.Instance.CopperPT = DataManager.Instance.CopperPT + 1;
            DataManager.Instance.Copper_Cost = DataManager.Instance.Copper_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 

    public void JE()
    {
        if(DataManager.Instance.jade_Cost <= DataManager.Instance.jade)
        {
            DataManager.Instance.jade =  DataManager.Instance.jade- DataManager.Instance.jade_Cost;
            DataManager.Instance.jadePT = DataManager.Instance.jadePT + 1;
            DataManager.Instance.jade_Cost = DataManager.Instance.jade_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 

    public void TE()
    {
        if(DataManager.Instance.Topaz_Cost <= DataManager.Instance.Topaz)
        {
            DataManager.Instance.Topaz = DataManager.Instance.Topaz - DataManager.Instance.Topaz_Cost ;
            DataManager.Instance.TopazPT = DataManager.Instance.TopazPT + 1;
            DataManager.Instance.Topaz_Cost = DataManager.Instance.Topaz_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 
}

