﻿using LeagueSharp.Common;

namespace Slutty_Utility.MenuConfig
{
    internal class JungleMenu : Helper
    {
        public static void LoadJungleMenu()
        {
            var oMenu = new Menu("Jungle Smite Options", "jungle.options.smite");
            {
                AddKeyBind(oMenu, "Auto Smite", "jungle.options.autoSmite", 'G', KeyBindType.Toggle);
                AddBool(oMenu, "Smite Buffs", "jungle.options.smiteBuffs", true);
                AddBool(oMenu, "Smite Epics", "jungle.options.smiteEpics", true);

               // AddBool(oMenu, "Smite Scuttle", "jungle.options.smiteScuttle", false);
              //  AddBool(oMenu, "Smite Krug", "jungle.options.smiteKrug", false);
             //   AddBool(oMenu, "Smite Wolf", "jungle.options.smiteWolf", false);
              //  AddBool(oMenu, "Smite Gromp", "jungle.options.smiteGromp", false);
              //  AddBool(oMenu, "Smite Raptors", "jungle.options.smiteRaptors", false);
               // AddBool(oMenu, "Smite Enemies For KS", "jungle.options.smiteChampions", false);
            }
            Config.AddSubMenu(oMenu);

            var oMenu2 = new Menu("Jungle Drawing Options", "jungle.options.drawing");
            {
                AddBool(oMenu2, "Display Smite Range", "jungle.options.drawing.range", true);
                AddBool(oMenu2, "Display Smite Damage", "jungle.options.drawing.damage", true);
                AddBool(oMenu2, "Fill Smite Damage", "jungle.options.drawing.damage.fill", true);
                AddBool(oMenu2, "Display Killable Text", "jungle.options.drawing.killable.text", true);
            }
            Config.AddSubMenu(oMenu2);
        }
    }
}