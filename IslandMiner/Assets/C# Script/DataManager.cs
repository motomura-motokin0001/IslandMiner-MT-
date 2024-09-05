using Unity.VisualScripting;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }

    public int SmallIslandCave_Stone_count;
    public int Grassland_Click_Stone_count;
    public int Desert_Cave_Click_Stone_count;
    public int Snowfield_Cave_Click_Stone_count;
    public int Volcano_Cave_Click_Stone_count;

//1-1~1-4

//-----Quantity-----
    public int coin = 0;
    public int Stone = 0;
    public int Iron = 0;
    public int Coal = 0;
    public int Gold = 0;

//-----Cost-----
    public int Stone_Cost = 10;
    public int Coal_Cost = 10;
    public int Iron_Cost = 10;
    public int Gold_Cost = 10;

//-----Increased value-----
    public int StonePT = 1;
    public int CoalPT = 1;
    public int IronPT = 1;
    public int GoldPT = 1;

    //2-1~2-4

//-----Quantity-----
    public int Bloodstone = 0;
    public int Copper = 0;
    public int jade = 0;
    public int Topaz =0;

//-----Cost-----
    public int Bloodstone_Cost = 10;
    public int Copper_Cost = 10;
    public int jade_Cost = 10;
    public int Topaz_Cost = 10;

//-----Increased value-----
    public int BloodstonePT = 1;
    public int CopperPT = 1;
    public int jadePT = 1;
    public int TopazPT = 1;

//3-1~3-4

//-----Quantity-----
    public int Silver = 0;
    public int Quartz = 0;
    public int Aquamarine = 0;
    public int Emerald =0;

//-----Cost-----
    public int Silver_Cost = 10;
    public int Quartz_Cost = 10;
    public int Aquamarine_Cost = 10;
    public int Emerald_Cost = 10;

//-----Increased value-----
    public int SilverPT = 1;
    public int QuartzPT = 1;
    public int AquamarinePT = 1;
    public int EmeraldPT = 1;

//4-1~4-4

//-----Quantity-----
public int Moonstone = 0; 
public int LapisLazuli = 0;
public int Amethyst = 0;
public int Ruby = 0;

//-----Cost-----
    public int Moonstone_Cost = 10;
    public int LapisLazuli_Cost = 10;
    public int Amethyst_Cost = 10;
    public int Ruby_Cost = 10;

//-----Increased value-----
    public int MoonstonePT = 1;
    public int LapisLazuliPT = 1;
    public int AmethystPT = 1;
    public int RubyPT = 1;

//5-1~5-4

//-----Quantity-----
    public int Obsidian = 0;
    public int Sulfur = 0;
    public int RoseQuartz = 0;
    public int Adamantite = 0;

//-----Cost-----
    public int Obsidian_Cost = 10;
    public int Sulfur_Cost = 10;
    public int RoseQuartz_Cost = 10;
    public int Adamantite_Cost = 10;

//-----Increased value-----
    public int ObsidianPT;
    public int SulfurPT;
    public int RoseQuartzPT;
    public int AdamantitePT;


    void Start()
    {
        Load();
    }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }



    public void Save()
    {
//Quantity
        PlayerPrefs.SetInt("stone_deta", Stone);
        PlayerPrefs.SetInt("coal_deta", Coal);
        PlayerPrefs.SetInt("iron_deta", Iron);
        PlayerPrefs.SetInt("gold_deta", Gold);

        PlayerPrefs.SetInt("Bloodstone_deta", Bloodstone);
        PlayerPrefs.SetInt("Copper_deta", Copper);
        PlayerPrefs.SetInt("jade_deta", jade);
        PlayerPrefs.SetInt("Topaz_deta", Topaz);

        PlayerPrefs.SetInt("Silver_deta", Silver);
        PlayerPrefs.SetInt("Quartz_deta", Quartz);
        PlayerPrefs.SetInt("Aquamarine_deta", Aquamarine);
        PlayerPrefs.SetInt("Emerald_deta", Emerald);

        PlayerPrefs.SetInt("Moonstone_deta", Moonstone);
        PlayerPrefs.SetInt("LapisLazuli_deta", LapisLazuli);
        PlayerPrefs.SetInt("Amethyst_deta", Amethyst);
        PlayerPrefs.SetInt("Ruby_deta", Ruby);

        PlayerPrefs.SetInt("Obsidian_deta", Obsidian);
        PlayerPrefs.SetInt("Sulfur_deta", Sulfur);
        PlayerPrefs.SetInt("RoseQuartz_deta", RoseQuartz);
        PlayerPrefs.SetInt("Adamantite_deta", Adamantite);

//Cost
        PlayerPrefs.SetInt("stone_Cost_deta", Stone_Cost);
        PlayerPrefs.SetInt("coal_Cost_deta", Coal_Cost);
        PlayerPrefs.SetInt("iron_Cost_deta", Iron_Cost);
        PlayerPrefs.SetInt("gold_Cost_deta", Gold_Cost);

        PlayerPrefs.SetInt("Bloodstone_Cost_deta", Bloodstone_Cost);
        PlayerPrefs.SetInt("Copper_Cost_deta", Copper_Cost);
        PlayerPrefs.SetInt("jade_Cost_deta", jade_Cost);
        PlayerPrefs.SetInt("Topaz_Cost_deta", Topaz_Cost);

        PlayerPrefs.SetInt("Silver_deta_Cost", Silver_Cost);
        PlayerPrefs.SetInt("Quartz_deta", Quartz_Cost);
        PlayerPrefs.SetInt("Aquamarine_Cost_deta", Aquamarine_Cost);
        PlayerPrefs.SetInt("Emerald_Cost_deta", Emerald_Cost);

        PlayerPrefs.SetInt("Moonstone_Cost_deta", Moonstone_Cost);
        PlayerPrefs.SetInt("LapisLazuli_Cost_deta", LapisLazuli_Cost);
        PlayerPrefs.SetInt("Amethyst_Cost_deta", Amethyst_Cost);
        PlayerPrefs.SetInt("Ruby_Cost_deta", Ruby_Cost);

        PlayerPrefs.SetInt("Obsidian_Cost_deta", Obsidian_Cost);
        PlayerPrefs.SetInt("Sulfur_Cost_deta", Sulfur_Cost);
        PlayerPrefs.SetInt("RoseQuartz_Cost_deta", RoseQuartz_Cost);
        PlayerPrefs.SetInt("Adamantite_Cost_deta", Adamantite_Cost);

//Increased value
        PlayerPrefs.SetInt("stonePT_deta", StonePT);
        PlayerPrefs.SetInt("coalPT_deta", CoalPT);
        PlayerPrefs.SetInt("ironPT_deta", IronPT);
        PlayerPrefs.SetInt("goldPT_deta", GoldPT);

        PlayerPrefs.SetInt("BloodstonePT_deta", BloodstonePT);
        PlayerPrefs.SetInt("CopperPT_deta", CopperPT);
        PlayerPrefs.SetInt("jadePT_deta", jadePT);
        PlayerPrefs.SetInt("TopazPT_deta", TopazPT);

        PlayerPrefs.SetInt("SilverPT_deta", SilverPT);
        PlayerPrefs.SetInt("QuartzPT_deta", QuartzPT);
        PlayerPrefs.SetInt("AquamarinePT_deta", AquamarinePT);
        PlayerPrefs.SetInt("EmeraldPT_deta", EmeraldPT);

        PlayerPrefs.SetInt("MoonstonePT_deta", MoonstonePT);
        PlayerPrefs.SetInt("LapisLazuliPT_deta", LapisLazuliPT);
        PlayerPrefs.SetInt("AmethystPT_deta", AmethystPT);
        PlayerPrefs.SetInt("RubyPT_deta", RubyPT);

        PlayerPrefs.SetInt("ObsidianPT_deta", ObsidianPT);
        PlayerPrefs.SetInt("SulfurPT_deta", SulfurPT);
        PlayerPrefs.SetInt("RoseQuartzPT_deta", RoseQuartzPT);
        PlayerPrefs.SetInt("AdamantitePT_deta", AdamantitePT);


        Debug.LogWarning("セーブしました");
    }

    void Load()
    {
//Quantity
        PlayerPrefs.GetInt("stone_deta", Stone);
        PlayerPrefs.GetInt("coal_deta", Coal);
        PlayerPrefs.GetInt("iron_deta", Iron);
        PlayerPrefs.GetInt("gold_deta", Gold);

        PlayerPrefs.GetInt("Bloodstone_deta", Bloodstone);
        PlayerPrefs.GetInt("Copper_deta", Copper);
        PlayerPrefs.GetInt("jade_deta", jade);
        PlayerPrefs.GetInt("Topaz_deta", Topaz);

        PlayerPrefs.GetInt("Silver_deta", Silver);
        PlayerPrefs.GetInt("Quartz_deta", Quartz);
        PlayerPrefs.GetInt("Aquamarine_deta", Aquamarine);
        PlayerPrefs.GetInt("Emerald_deta", Emerald);

        PlayerPrefs.GetInt("Moonstone_deta", Moonstone);
        PlayerPrefs.GetInt("LapisLazuli_deta", LapisLazuli);
        PlayerPrefs.GetInt("Amethyst_deta", Amethyst);
        PlayerPrefs.GetInt("Ruby_deta", Ruby);

        PlayerPrefs.GetInt("Obsidian_deta", Obsidian);
        PlayerPrefs.GetInt("Sulfur_deta", Sulfur);
        PlayerPrefs.GetInt("RoseQuartz_deta", RoseQuartz);
        PlayerPrefs.GetInt("Adamantite_deta", Adamantite);

//Cost
        PlayerPrefs.GetInt("stone_Cost_deta", Stone_Cost);
        PlayerPrefs.GetInt("coal_Cost_deta", Coal_Cost);
        PlayerPrefs.GetInt("iron_Cost_deta", Iron_Cost);
        PlayerPrefs.GetInt("gold_Cost_deta", Gold_Cost);

        PlayerPrefs.GetInt("Bloodstone_Cost_deta", Bloodstone_Cost);
        PlayerPrefs.GetInt("Copper_Cost_deta", Copper_Cost);
        PlayerPrefs.GetInt("jade_Cost_deta", jade_Cost);
        PlayerPrefs.GetInt("Topaz_Cost_deta", Topaz_Cost);

        PlayerPrefs.GetInt("Silver_deta_Cost", Silver_Cost);
        PlayerPrefs.GetInt("Quartz_deta", Quartz_Cost);
        PlayerPrefs.GetInt("Aquamarine_Cost_deta", Aquamarine_Cost);
        PlayerPrefs.GetInt("Emerald_Cost_deta", Emerald_Cost);

        PlayerPrefs.GetInt("Moonstone_Cost_deta", Moonstone_Cost);
        PlayerPrefs.GetInt("LapisLazuli_Cost_deta", LapisLazuli_Cost);
        PlayerPrefs.GetInt("Amethyst_Cost_deta", Amethyst_Cost);
        PlayerPrefs.GetInt("Ruby_Cost_deta", Ruby_Cost);

        PlayerPrefs.GetInt("Obsidian_Cost_deta", Obsidian_Cost);
        PlayerPrefs.GetInt("Sulfur_Cost_deta", Sulfur_Cost);
        PlayerPrefs.GetInt("RoseQuartz_Cost_deta", RoseQuartz_Cost);
        PlayerPrefs.GetInt("Adamantite_Cost_deta", Adamantite_Cost);

//Increased value
        PlayerPrefs.GetInt("stonePT_deta", StonePT);
        PlayerPrefs.GetInt("coalPT_deta", CoalPT);
        PlayerPrefs.GetInt("ironPT_deta", IronPT);
        PlayerPrefs.GetInt("goldPT_deta", GoldPT);

        PlayerPrefs.GetInt("BloodstonePT_deta", BloodstonePT);
        PlayerPrefs.GetInt("CopperPT_deta", CopperPT);
        PlayerPrefs.GetInt("jadePT_deta", jadePT);
        PlayerPrefs.GetInt("TopazPT_deta", TopazPT);

        PlayerPrefs.GetInt("SilverPT_deta", SilverPT);
        PlayerPrefs.GetInt("QuartzPT_deta", QuartzPT);
        PlayerPrefs.GetInt("AquamarinePT_deta", AquamarinePT);
        PlayerPrefs.GetInt("EmeraldPT_deta", EmeraldPT);

        PlayerPrefs.GetInt("MoonstonePT_deta", MoonstonePT);
        PlayerPrefs.GetInt("LapisLazuliPT_deta", LapisLazuliPT);
        PlayerPrefs.GetInt("AmethystPT_deta", AmethystPT);
        PlayerPrefs.GetInt("RubyPT_deta", RubyPT);

        PlayerPrefs.GetInt("ObsidianPT_deta", ObsidianPT);
        PlayerPrefs.GetInt("SulfurPT_deta", SulfurPT);
        PlayerPrefs.GetInt("RoseQuartzPT_deta", RoseQuartzPT);
        PlayerPrefs.GetInt("AdamantitePT_deta", AdamantitePT);

        Debug.Log("ロードしました。");
    }
}