using BepInEx;
using HarmonyLib;
using ItemManager;
using UnityEngine;

namespace ScribeArmorColor
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    [BepInDependency("DarkArmor", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
    {
        internal const string ModName = "ScribeArmorColor", ModVersion = "0.0.1", ModGUID = "com.Frogger." + ModName;
        private static readonly Harmony harmony = new(ModGUID);
        internal static Plugin _self;
        private AssetBundle assetBundle;
        internal Material chestMaterial;
        internal Sprite helmetNIcon;
        internal Sprite armorNIcon;
        internal Sprite armorOIcon;
        internal Sprite helmetOIcon;
        internal Sprite legsOIcon;

        private void Awake()
        {
            _self = this;

            assetBundle = PrefabManager.RegisterAssetBundle("armor");
            chestMaterial = assetBundle.LoadAsset<Material>("ChestMaterial");
            helmetNIcon = assetBundle.LoadAsset<Sprite>("HelmetIcon");
            armorNIcon = assetBundle.LoadAsset<Sprite>("ArmorIcon");

            armorOIcon = assetBundle.LoadAsset<Sprite>("OdinsArmor");
            helmetOIcon = assetBundle.LoadAsset<Sprite>("OdinsHelmet");
            legsOIcon = assetBundle.LoadAsset<Sprite>("OdinsLegs");

            harmony.PatchAll();
        }

        internal void Debug(string msg)
        {
            Logger.LogInfo(msg);
        }
    }
}