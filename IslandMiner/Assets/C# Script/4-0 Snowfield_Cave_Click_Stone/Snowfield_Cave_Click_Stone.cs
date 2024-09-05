using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Animations;


public class Snowfield_Cave_Click_Stone : MonoBehaviour
{
    
    public Button SCCS_Clickstone;
    public Button Moonstone_Enhancement;
    public Button LapisLazuli_Enhancement;
    public Button Amethyst_Enhancement;
    public Button Ruby_Enhancement;
    public Text SCCS_countText;
    public TextMeshProUGUI Moonstone_CostText;
    public TextMeshProUGUI LapisLazuli_CostText;
    public TextMeshProUGUI Amethyst_CostText;
    public TextMeshProUGUI Ruby_CostText;
    public TextMeshProUGUI Moonstonetext;
    public TextMeshProUGUI LapisLazulitext;
    public TextMeshProUGUI AmethystText;
    public TextMeshProUGUI Rubytext;



    private int  Randomnumbr = 0;



    void Start()
    {
        SCCS_Clickstone.onClick.AddListener(SCCS_IncrementCount);
        Moonstone_Enhancement.onClick.AddListener(ME);
        LapisLazuli_Enhancement.onClick.AddListener(LE);
        Amethyst_Enhancement.onClick.AddListener(AmE);
        Ruby_Enhancement.onClick.AddListener(RE);
        
        SCCS_UpdateCountText();
        
    }
    void SCCS_RandomNB()
    {
        Randomnumbr = Random.Range(1,5);
        Debug.Log(Randomnumbr);
    }


    void SCCS_IncrementCount()
    {
        DataManager.Instance.Snowfield_Cave_Click_Stone_count++; 
        SCCS_UpdateCountText();
        SCCS_RandomNB();
    }

    void SCCS_UpdateCountText()
    {
        SCCS_countText.text = DataManager.Instance.Snowfield_Cave_Click_Stone_count.ToString() + "回";
    }

    void Update()
    {
        Moonstonetext.text = DataManager.Instance.Moonstone.ToString();
        LapisLazulitext.text = DataManager.Instance.LapisLazuli.ToString();
        AmethystText.text = DataManager.Instance.Amethyst.ToString();
        Rubytext.text = DataManager.Instance.Ruby.ToString();
        Moonstone_CostText.text = "cost" + DataManager.Instance.Moonstone_Cost.ToString();
        LapisLazuli_CostText.text = "cost" + DataManager.Instance.LapisLazuli_Cost.ToString();
        Amethyst_CostText.text = "cost" + DataManager.Instance.Amethyst_Cost.ToString();
        Ruby_CostText.text = "cost" + DataManager.Instance.Ruby_Cost.ToString();


        if (Randomnumbr == 1)//Moonstone
        {
            int newmoonstoneValue = DataManager.Instance.Moonstone + DataManager.Instance.MoonstonePT;
            DataManager.Instance.Moonstone = newmoonstoneValue;
            Moonstonetext.text = newmoonstoneValue.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 2)//LapisLazuli
        {
            int newlapislazuliValue = DataManager.Instance.LapisLazuli + DataManager.Instance.LapisLazuliPT;
            DataManager.Instance.LapisLazuli = newlapislazuliValue;
            LapisLazulitext.text = newlapislazuliValue.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 3)//Amethyst
        {
            int newaquamarineValue = DataManager.Instance.Amethyst + DataManager.Instance.AmethystPT;
            DataManager.Instance.Amethyst = newaquamarineValue;
            AmethystText.text = newaquamarineValue.ToString();
            Randomnumbr = 0;
        }

        if (Randomnumbr == 4)
        {
            int newrubyValue = DataManager.Instance.Ruby + DataManager.Instance.RubyPT;
            DataManager.Instance.Ruby = newrubyValue;
            Rubytext.text = newrubyValue.ToString();
            Randomnumbr = 0;
        }
    }

    public void ME()
    {
        if(DataManager.Instance.Moonstone_Cost <= DataManager.Instance.Moonstone)
        {
            DataManager.Instance.Moonstone = DataManager.Instance.Moonstone - DataManager.Instance.Moonstone_Cost;
            DataManager.Instance.MoonstonePT = DataManager.Instance.MoonstonePT + 1;
            DataManager.Instance.Moonstone_Cost = DataManager.Instance.Moonstone_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 

    public void LE()
    {
        if(DataManager.Instance.LapisLazuli_Cost <= DataManager.Instance.LapisLazuli)
        {
            DataManager.Instance.LapisLazuli = DataManager.Instance.Coal - DataManager.Instance.LapisLazuli_Cost;
            DataManager.Instance.LapisLazuliPT = DataManager.Instance.LapisLazuliPT + 1;
            DataManager.Instance.LapisLazuli_Cost = DataManager.Instance.LapisLazuli_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 

    public void AmE()
    {
        if(DataManager.Instance.Amethyst_Cost <= DataManager.Instance.Amethyst)
        {
            DataManager.Instance.Amethyst =  DataManager.Instance.Amethyst- DataManager.Instance.Amethyst_Cost;
            DataManager.Instance.AmethystPT = DataManager.Instance.AmethystPT + 1;
            DataManager.Instance.Amethyst_Cost = DataManager.Instance.Amethyst_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 

    public void RE()
    {
        if(DataManager.Instance.Ruby_Cost <= DataManager.Instance.Ruby)
        {
            DataManager.Instance.Ruby = DataManager.Instance.Ruby - DataManager.Instance.Ruby_Cost ;
            DataManager.Instance.RubyPT = DataManager.Instance.RubyPT + 1;
            DataManager.Instance.Ruby_Cost = DataManager.Instance.Ruby_Cost * 2;
            Debug.Log("強化出来ました！");
        }
        else
        {
            Debug.Log("強化できませんでした。");
        }
    } 
}

