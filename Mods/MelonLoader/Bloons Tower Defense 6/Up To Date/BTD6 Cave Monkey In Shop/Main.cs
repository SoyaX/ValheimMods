﻿using Assets.Scripts.Models.Towers;
using Assets.Scripts.Unity;
using Assets.Scripts.Utils;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.ModOptions;
using BTD_Mod_Helper.Api.Towers;
using MelonLoader;
[assembly: MelonInfo(typeof(BTD6_Cave_Monkey_In_Shop.Class1), "Cave Monkey In Shop", "3.0.0", "kenx00x")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace BTD6_Cave_Monkey_In_Shop
{
    public class Class1 : BloonsTD6Mod
    {
        public static readonly ModSettingInt Price = new ModSettingInt(250);
        public override void OnApplicationStart()
        {
            LoggerInstance.Msg("Cave Monkey In Shop mod loaded");
        }
    }
    public class CaveMonkey : ModTower
    {
        public override SpriteReference PortraitReference => Game.instance.model.GetPowerWithName("CaveMonkey").icon;
        public override SpriteReference IconReference => Game.instance.model.GetPowerWithName("CaveMonkey").icon;
        public override string TowerSet => PRIMARY;
        public override string BaseTower => TowerType.CaveMonkey;
        public override int Cost => Class1.Price;
        public override int TopPathUpgrades => 0;
        public override int MiddlePathUpgrades => 0;
        public override int BottomPathUpgrades => 0;
        public override string Description => "Cave Monkey";
        public override void ModifyBaseTowerModel(TowerModel towerModel)
        { }
    }
}