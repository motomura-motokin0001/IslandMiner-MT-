using CI.QuickSave;
using UnityEngine;
[System.Serializable]

public class GameData
{
        public static GameData Instance { get;  set; } 

        #region 各石のクリック数
            public int SmallIslandCave_Stone_count =0;
            public int Grassland_Click_Stone_count =0;
            public int Desert_Cave_Click_Stone_count =0;
            public int Snowfield_Cave_Click_Stone_count =0;
            public int Volcano_Cave_Click_Stone_count =0;
        #endregion

        #region 小さな島の洞窟_宣言
            #region -----Quantity-----
                public int coin = 0;
                public int Stone = 0;
                public int Iron = 0;
                public int Coal = 0;
                public int Gold = 0;
            #endregion
            #region -----Cost----
                public int Stone_Cost = 10;
                public int Coal_Cost = 10;
                public int Iron_Cost = 10;
                public int Gold_Cost = 10;
            #endregion
            #region -----Increased value-----
                public int StonePT = 1;
                public int CoalPT = 1;
                public int IronPT = 1;
                public int GoldPT = 1;
            #endregion
        #endregion

        #region 草原の洞窟_宣言
            #region -----Quantity-----
                public int Bloodstone = 0;
                public int Copper = 0;
                public int jade = 0;
                public int Topaz =0;
            #endregion
            #region -----Cost-----
                public int Bloodstone_Cost = 10;
                public int Copper_Cost = 10;
                public int jade_Cost = 10;
                public int Topaz_Cost = 10;
            #endregion
            #region -----Increased value-----
                public int BloodstonePT = 1;
                public int CopperPT = 1;
                public int jadePT = 1;
                public int TopazPT = 1;
            #endregion
        #endregion

        // #region 砂漠の洞窟_宣言
        //     #region -----Quantity-----
        //         public int Silver = 0;
        //         public int Quartz = 0;
        //         public int Aquamarine = 0;
        //         public int Emerald =0;
        //     #endregion
        //     #region -----Cost-----
        //         public int Silver_Cost = 10;
        //         public int Quartz_Cost = 10;
        //         public int Aquamarine_Cost = 10;
        //         public int Emerald_Cost = 10;
        //     #endregion

        //     #region -----Increased value-----
        //         public int SilverPT = 1;
        //         public int QuartzPT = 1;
        //         public int AquamarinePT = 1;
        //         public int EmeraldPT = 1;
        //     #endregion
        // #endregion

        // #region 雪原の洞窟_宣言
        //     #region -----Quantity-----
        //         public int Moonstone = 0; 
        //         public int LapisLazuli = 0;
        //         public int Amethyst = 0;
        //         public int Ruby = 0;
        //     #endregion
        //     #region -----Cost-----
        //         public int Moonstone_Cost = 10;
        //         public int LapisLazuli_Cost = 10;
        //         public int Amethyst_Cost = 10;
        //         public int Ruby_Cost = 10;
        //     #endregion
        //     #region -----Increased value-----
        //         public int MoonstonePT = 1;
        //         public int LapisLazuliPT = 1;
        //         public int AmethystPT = 1;
        //         public int RubyPT = 1;
        //     #endregion
        // #endregion

        // #region 火山の洞窟_宣言
        //     #region -----Quantity-----
        //         public int Obsidian = 0;
        //         public int Sulfur = 0;
        //         public int RoseQuartz = 0;
        //         public int Adamantite = 0;
        //     #endregion
        //     #region -----Cost-----
        //         public int Obsidian_Cost = 10;
        //         public int Sulfur_Cost = 10;
        //         public int RoseQuartz_Cost = 10;
        //         public int Adamantite_Cost = 10;
        //     #endregion
        //     #region -----Increased value-----
        //         public int ObsidianPT = 1;
        //         public int SulfurPT = 1;
        //         public int RoseQuartzPT = 1;
        //         public int AdamantitePT = 1;
        //     #endregion
        // #endregion

    }
