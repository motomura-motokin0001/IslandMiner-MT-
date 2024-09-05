using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Desert_Cave_Click_Stone : MonoBehaviour
{
    
    public Button DCCS_Clickstone;
    public Button Silver_Enhancement;
    public Button Quartz_Enhancement;
    public Button Aquamarine_Enhancement;
    public Button Emerald_Enhancement;
    public Text DCCS_countText;
    public TextMeshProUGUI Silver_CostText;
    public TextMeshProUGUI Quartz_CostText;
    public TextMeshProUGUI Aquamarine_CostText;
    public TextMeshProUGUI Emerald_CostText;
    public TextMeshProUGUI Silvertext;
    public TextMeshProUGUI Quartztext;
    public TextMeshProUGUI AquamarineText;
    public TextMeshProUGUI Emeraldtext;



    private int  Randomnumbr = 0;



    void Start()
    {
        DCCS_Clickstone.onClick.AddListener(DCCS_IncrementCount);
        Silver_Enhancement.onClick.AddListener(SE);
        Quartz_Enhancement.onClick.AddListener(QE);
        Aquamarine_Enhancement.onClick.AddListener(AE);
        Emerald_Enhancement.onClick.AddListener(EE);
        
        DCCS_UpdateCountText();
        
    }
    void DCCS_RandomNB()
    {
        Randomnumbr = Random.Range(1,5);
        Debug.Log(Randomnumbr);
    }


    void DCCS_IncrementCount()
    {
        DataManager.Instance.Desert_Cave_Click_Stone_count++; 
        DCCS_UpdateCountText();
        DCCS_RandomNB();
    }

    void DCCS_UpdateCountText()
    {
        DCCS_countText.text = DataManager.Instance.Desert_Cave_Click_Stone_count.ToString() + "回";
    }

    void Update()
    {
        Silvertext.text = DataManager.Instance.Silver.ToString();
        Quartztext.text = DataManager.Instance.Quartz.ToString();
        AquamarineText.text = DataManager.Instance.Aquamarine.ToString();
        Emeraldtext.text = DataManager.Instance.Emerald.ToString();
        Silver_CostText.text = "cost" + DataManager.Instance.Silver_Cost.ToString();
        Quartz_CostText.text = "cost" + DataManager.Instance.Quartz_Cost.ToString();
        Aquamarine_CostText.text = "cost" + DataManager.Instance.Aquamarine_Cost.ToString();
        Emerald_CostText.text = "cost" + DataManager.Instance.Emerald_Cost.ToString();


        if (Randomnumbr == 1)
        {
            int newsilverValue = DataManager.Instance.Silver + DataManager.Instance.SilverPT;
            DataManager.Instance.Silver = newsilverValue;
            Silvertext.text = newsilverValue.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 2)
        {
            int newquartzValue = DataManager.Instance.Quartz + DataManager.Instance.QuartzPT;
            DataManager.Instance.Quartz = newquartzValue;
            Quartztext.text = newquartzValue.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 3)
        {
            int newaquamarineValue = DataManager.Instance.Aquamarine + DataManager.Instance.AquamarinePT;
            DataManager.Instance.Aquamarine = newaquamarineValue;
            AquamarineText.text = newaquamarineValue.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 4)
        {
            int newEmeraldValue = DataManager.Instance.Emerald + DataManager.Instance.EmeraldPT;
            DataManager.Instance.Emerald = newEmeraldValue;
            Emeraldtext.text = newEmeraldValue.ToString();
            Randomnumbr = 0;
        }
    }

    public void SE()
    {
        if(DataManager.Instance.Silver_Cost <= DataManager.Instance.Silver)
        {
            DataManager.Instance.Silver = DataManager.Instance.Silver - DataManager.Instance.Silver_Cost;
            DataManager.Instance.SilverPT = DataManager.Instance.SilverPT + 1;
            DataManager.Instance.Silver_Cost = DataManager.Instance.Silver_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 

    public void QE()
    {
        if(DataManager.Instance.Quartz_Cost <= DataManager.Instance.Quartz)
        {
            DataManager.Instance.Quartz = DataManager.Instance.Coal - DataManager.Instance.Quartz_Cost;
            DataManager.Instance.QuartzPT = DataManager.Instance.QuartzPT + 1;
            DataManager.Instance.Quartz_Cost = DataManager.Instance.Quartz_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 

    public void AE()
    {
        if(DataManager.Instance.Aquamarine_Cost <= DataManager.Instance.Aquamarine)
        {
            DataManager.Instance.Aquamarine =  DataManager.Instance.Aquamarine- DataManager.Instance.Aquamarine_Cost;
            DataManager.Instance.AquamarinePT = DataManager.Instance.AquamarinePT + 1;
            DataManager.Instance.Aquamarine_Cost = DataManager.Instance.Aquamarine_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 

    public void EE()
    {
        if(DataManager.Instance.Emerald_Cost <= DataManager.Instance.Emerald)
        {
            DataManager.Instance.Emerald = DataManager.Instance.Emerald - DataManager.Instance.Emerald_Cost ;
            DataManager.Instance.EmeraldPT = DataManager.Instance.EmeraldPT + 1;
            DataManager.Instance.Emerald_Cost = DataManager.Instance.Emerald_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 
}

