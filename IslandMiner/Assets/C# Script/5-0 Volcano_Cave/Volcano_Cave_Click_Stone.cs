using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Animations;


public class Volcano_Cave_Click_Stone : MonoBehaviour
{
    
    public Button VCCS_Clickstone;
    public Button Obsidian_Enhancement;
    public Button sulfur_Enhancement;
    public Button RoseQuartz_Enhancement;
    public Button Adamantite_Enhancement;
    public Text VCCS_countText;
    public TextMeshProUGUI Obsidian_CostText;
    public TextMeshProUGUI sulfur_CostText;
    public TextMeshProUGUI RoseQuartz_CostText;
    public TextMeshProUGUI Adamantite_CostText;
    public TextMeshProUGUI Obsidiantext;
    public TextMeshProUGUI Sulfurtext;
    public TextMeshProUGUI RoseQuartzText;
    public TextMeshProUGUI Adamantitetext;

    private int  Randomnumbr = 0;

    void Start()
    {
        VCCS_Clickstone.onClick.AddListener(VCCS_IncrementCount);
        Obsidian_Enhancement.onClick.AddListener(OE);
        sulfur_Enhancement.onClick.AddListener(SE);
        RoseQuartz_Enhancement.onClick.AddListener(AE);
        Adamantite_Enhancement.onClick.AddListener(AE);
        
        VCCS_UpdateCountText();
        
    }
    void VCCS_RandomNB()
    {
        Randomnumbr = Random.Range(1,5);
        Debug.Log(Randomnumbr);
    }


    void VCCS_IncrementCount()
    {
        DataManager.Instance.Volcano_Cave_Click_Stone_count++; 
        VCCS_UpdateCountText();
        VCCS_RandomNB();
    }

    void VCCS_UpdateCountText()
    {
        VCCS_countText.text = DataManager.Instance.Volcano_Cave_Click_Stone_count.ToString() + "回";
    }

    void Update()
    {
        Obsidiantext.text = DataManager.Instance.Obsidian.ToString();
        Sulfurtext.text = DataManager.Instance.Sulfur.ToString();
        RoseQuartzText.text = DataManager.Instance.RoseQuartz.ToString();
        Adamantitetext.text = DataManager.Instance.Adamantite.ToString();
        Obsidian_CostText.text = "cost" + DataManager.Instance.Obsidian_Cost.ToString();
        sulfur_CostText.text = "cost" + DataManager.Instance.Sulfur_Cost.ToString();
        RoseQuartz_CostText.text = "cost" + DataManager.Instance.RoseQuartz_Cost.ToString();
        Adamantite_CostText.text = "cost" + DataManager.Instance.Adamantite_Cost.ToString();


        if (Randomnumbr == 1)
        {
            int newobsidianValue = DataManager.Instance.Obsidian + DataManager.Instance.ObsidianPT;
            DataManager.Instance.Obsidian = newobsidianValue;
            Obsidiantext.text = newobsidianValue.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 2)
        {
            int newsulfurValue = DataManager.Instance.Sulfur + DataManager.Instance.SulfurPT;
            DataManager.Instance.Sulfur = newsulfurValue;
            Sulfurtext.text = newsulfurValue.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 3)
        {
            int newrosequartzValue = DataManager.Instance.RoseQuartz + DataManager.Instance.RoseQuartzPT;
            DataManager.Instance.RoseQuartz = newrosequartzValue;
            RoseQuartzText.text = newrosequartzValue.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 4)
        {
            int newadamantiteValue = DataManager.Instance.Adamantite + DataManager.Instance.AdamantitePT;
            DataManager.Instance.Adamantite = newadamantiteValue;
            Adamantitetext.text = newadamantiteValue.ToString();
            Randomnumbr = 0;
        }
    }

    public void OE()
    {
        if(DataManager.Instance.Obsidian_Cost <= DataManager.Instance.Obsidian)
        {
            DataManager.Instance.Obsidian = DataManager.Instance.Obsidian - DataManager.Instance.Obsidian_Cost;
            DataManager.Instance.ObsidianPT = DataManager.Instance.ObsidianPT + 1;
            DataManager.Instance.Obsidian_Cost = DataManager.Instance.Obsidian_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 

    public void SE()
    {
        if(DataManager.Instance.Sulfur_Cost <= DataManager.Instance.Sulfur)
        {
            DataManager.Instance.Sulfur = DataManager.Instance.Coal - DataManager.Instance.Sulfur_Cost;
            DataManager.Instance.SulfurPT = DataManager.Instance.SulfurPT + 1;
            DataManager.Instance.Sulfur_Cost = DataManager.Instance.Sulfur_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 

    public void RE()
    {
        if(DataManager.Instance.RoseQuartz_Cost <= DataManager.Instance.RoseQuartz)
        {
            DataManager.Instance.RoseQuartz =  DataManager.Instance.RoseQuartz- DataManager.Instance.RoseQuartz_Cost;
            DataManager.Instance.RoseQuartzPT = DataManager.Instance.RoseQuartzPT + 1;
            DataManager.Instance.RoseQuartz_Cost = DataManager.Instance.RoseQuartz_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 

    public void AE()
    {
        if(DataManager.Instance.Adamantite_Cost <= DataManager.Instance.Adamantite)
        {
            DataManager.Instance.Adamantite = DataManager.Instance.Adamantite - DataManager.Instance.Adamantite_Cost ;
            DataManager.Instance.AdamantitePT = DataManager.Instance.AdamantitePT + 1;
            DataManager.Instance.Adamantite_Cost = DataManager.Instance.Adamantite_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 
}

