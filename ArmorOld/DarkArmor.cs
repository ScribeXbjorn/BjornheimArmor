using System.IO;
using System.Linq;
using System.Reflection;
using BepInEx;
using ItemManager;
using UnityEngine;

namespace DarkArmor
{
    [BepInPlugin(GUID, PluginName, PluginVersion)]
    public class DarkArmor : BaseUnityPlugin
    {
        private const string GUID = "DarkArmor";
        private const string PluginName = "DarkArmor";
        private const string PluginVersion = "1.0.0";

        private void Awake()
        {
            AssetBundle asset = GetAssetBundle("darkarmor");
            
            Item darkChest = new(asset.LoadAsset<GameObject>("DarkChest"));
            darkChest.Name.English("Fenring Chest");
            darkChest.Description.English("A chestplate made from the scales of Fenring, the Black Dragon.");
            darkChest.Crafting.Add(CraftingTable.Forge, 1);
            darkChest.RequiredItems.Add("Silver", 10);
            darkChest.RequiredItems.Add("Iron", 10);
            darkChest.RequiredItems.Add("BoneFragments", 2);
            darkChest.RequiredItems.Add("Mushroom", 2);
            darkChest.RequiredUpgradeItems.Add("Silver", 6);
            darkChest.Configurable = Configurability.Disabled;
            
            Item darkLegs = new(asset.LoadAsset<GameObject>("DarkLegs"));
            darkLegs.Name.English("Fenring Greaves");
            darkLegs.Description.English("Greaves made from the scales of Fenring, the Black Dragon.");
            darkLegs.Crafting.Add(CraftingTable.Forge, 1);
            darkLegs.RequiredItems.Add("Silver", 10);
            darkLegs.RequiredItems.Add("Iron", 10);
            darkLegs.RequiredItems.Add("BoneFragments", 2);
            darkLegs.RequiredItems.Add("Mushroom", 2);
            darkLegs.RequiredUpgradeItems.Add("Silver", 6);
            darkLegs.Configurable = Configurability.Disabled;
            
            Item darkHelmet = new(asset.LoadAsset<GameObject>("DarkHelmet"));
            darkHelmet.Name.English("Fenring Helmet");
            darkHelmet.Description.English("A helmet for greatest fighters");
            darkHelmet.Crafting.Add(CraftingTable.Forge, 1);
            darkHelmet.RequiredItems.Add("Silver", 5);
            darkHelmet.RequiredItems.Add("Iron", 5);
            darkHelmet.RequiredItems.Add("BoneFragments", 1);
            darkHelmet.RequiredItems.Add("Mushroom", 1);
            darkHelmet.RequiredUpgradeItems.Add("Silver", 3);
            darkHelmet.Configurable = Configurability.Disabled;

            Item balrogChest = new(asset.LoadAsset<GameObject>("BalrogsChest"));
            balrogChest.Name.English("Balrog Chest");
            balrogChest.Description.English("A chestplate made from the scales of Balrog, the Black Dragon.");
            balrogChest.Crafting.Add(CraftingTable.Forge, 1);
            balrogChest.RequiredItems.Add("Silver", 10);
            balrogChest.RequiredItems.Add("Iron", 20);
            balrogChest.RequiredItems.Add("Bloodbag", 2);
            balrogChest.RequiredItems.Add("Coal", 2);
            balrogChest.RequiredUpgradeItems.Add("Silver", 6);
            balrogChest.Configurable = Configurability.Disabled;

            Item balrogLegs = new(asset.LoadAsset<GameObject>("BalrogsLegs"));
            balrogLegs.Name.English("Balrog Greaves");
            balrogLegs.Description.English("A greaves made from the scales of Balrog, the Black Dragon.");
            balrogLegs.Crafting.Add(CraftingTable.Forge, 1);
            balrogLegs.RequiredItems.Add("Silver", 10);
            balrogLegs.RequiredItems.Add("Iron", 20);
            balrogLegs.RequiredItems.Add("Bloodbag", 2);
            balrogLegs.RequiredItems.Add("Coal", 2);
            balrogLegs.RequiredUpgradeItems.Add("Silver", 6);
            balrogLegs.Configurable = Configurability.Disabled;

            Item balrogHelmet = new(asset.LoadAsset<GameObject>("BalrogsHelmet"));
            balrogHelmet.Name.English("Balrog Helmet");
            balrogHelmet.Description.English("A helmet for greatest fighters");
            balrogHelmet.Crafting.Add(CraftingTable.Forge, 1);
            balrogHelmet.RequiredItems.Add("Silver", 5);
            balrogHelmet.RequiredItems.Add("Iron", 5);
            balrogHelmet.RequiredItems.Add("Bloodbag", 1);
            balrogHelmet.RequiredItems.Add("Coal", 1);
            balrogHelmet.RequiredUpgradeItems.Add("Silver", 3);
            balrogHelmet.Configurable = Configurability.Disabled;
            
            Item byzaniteChest = new(asset.LoadAsset<GameObject>("ByzantiteChest"));
            byzaniteChest.Name.English("Byzantine Empire Chest");
            byzaniteChest.Description.English("A great chestplate");
            byzaniteChest.Crafting.Add(CraftingTable.Forge, 1);
            byzaniteChest.RequiredItems.Add("Silver", 10); 
            byzaniteChest.RequiredItems.Add("Iron", 20);
            byzaniteChest.RequiredItems.Add("Blueberries", 2);
            byzaniteChest.RequiredItems.Add("Raspberry", 2);
            byzaniteChest.RequiredUpgradeItems.Add("Silver", 6);
            byzaniteChest.Configurable = Configurability.Disabled;
            
            Item byzaniteLegs = new(asset.LoadAsset<GameObject>("ByzantiteLegs")); 
            byzaniteLegs.Name.English("Byzantine Empire Legs");
            byzaniteLegs.Description.English("A great greaves");
            byzaniteLegs.Crafting.Add(CraftingTable.Forge, 1);
            byzaniteLegs.RequiredItems.Add("Silver", 10); 
            byzaniteLegs.RequiredItems.Add("Iron", 20);
            byzaniteLegs.RequiredItems.Add("Blueberries", 2);
            byzaniteLegs.RequiredItems.Add("Raspberry", 2);
            byzaniteLegs.RequiredUpgradeItems.Add("Silver", 6);
            byzaniteLegs.Configurable = Configurability.Disabled;
             
            Item byzaniteHelmet = new(asset.LoadAsset<GameObject>("ByzantiteHelmet"));
            byzaniteHelmet.Name.English("Byzantine Empire Helmet");
            byzaniteHelmet.Description.English("A great helmet");
            byzaniteHelmet.Crafting.Add(CraftingTable.Forge, 1);
            byzaniteHelmet.RequiredItems.Add("Silver", 5); 
            byzaniteHelmet.RequiredItems.Add("Iron", 5);
            byzaniteHelmet.RequiredItems.Add("Blueberries", 1);
            byzaniteHelmet.RequiredItems.Add("Raspberry", 1);
            byzaniteHelmet.RequiredUpgradeItems.Add("Silver", 3);
            byzaniteHelmet.Configurable = Configurability.Disabled;
            
            Item odinChest = new(asset.LoadAsset<GameObject>("SonOfOdinChest"));
            odinChest.Prefab.name = "LokiSerpentsChest";
            odinChest.Name.English("Son Of Odin Chest");
            odinChest.Description.English("A great chestplate");
            odinChest.Crafting.Add(CraftingTable.Forge, 1);
            odinChest.RequiredItems.Add("Silver", 10); 
            odinChest.RequiredItems.Add("Iron", 20);
            odinChest.RequiredItems.Add("Guck", 2); 
            odinChest.RequiredItems.Add("MushroomYellow", 2);
            odinChest.RequiredUpgradeItems.Add("Silver", 6);
            odinChest.Configurable = Configurability.Disabled;
            
            Item odinLegs = new(asset.LoadAsset<GameObject>("SonOfOdinLegs"));  
            odinLegs.Prefab.name = "LokiSerpentsLegs";
            odinLegs.Name.English("Loki's Serpents Legs"); 
            odinLegs.Description.English("A great greaves");
            odinLegs.Crafting.Add(CraftingTable.Forge, 1);
            odinLegs.RequiredItems.Add("Silver", 10); 
            odinLegs.RequiredItems.Add("Iron", 20);
            odinLegs.RequiredItems.Add("Guck", 2);
            odinLegs.RequiredItems.Add("MushroomYellow", 2);
            odinLegs.RequiredUpgradeItems.Add("Silver", 6);
            odinLegs.Configurable = Configurability.Disabled;
             
            Item odinHelmet = new(asset.LoadAsset<GameObject>("SonOfOdinHelmet"));
            odinHelmet.Prefab.name = "LokiSerpentsHelmet";
            odinHelmet.Name.English("Loki's Serpents Helmet");
            odinHelmet.Description.English("A great helmet");
            odinHelmet.Crafting.Add(CraftingTable.Forge, 1);
            odinHelmet.RequiredItems.Add("Silver", 5); 
            odinHelmet.RequiredItems.Add("Iron", 5);
            odinHelmet.RequiredItems.Add("Guck", 1);
            odinHelmet.RequiredItems.Add("MushroomYellow", 1);
            odinHelmet.RequiredUpgradeItems.Add("Silver", 3);
            odinHelmet.Configurable = Configurability.Disabled;
        }
         


        private static AssetBundle GetAssetBundle(string filename)
        {
            Assembly execAssembly = Assembly.GetExecutingAssembly();
            string resourceName = execAssembly.GetManifestResourceNames().Single(str => str.EndsWith(filename));
            using Stream stream = execAssembly.GetManifestResourceStream(resourceName);
            return AssetBundle.LoadFromStream(stream);
        }
    }
}