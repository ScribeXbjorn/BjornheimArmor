using HarmonyLib;
using UnityEngine;
using static ScribeArmorColor.Plugin;

namespace ScribeArmorColor
{
    [HarmonyPatch]
    internal class Patch
    {
        [HarmonyPatch(typeof(ObjectDB), nameof(ObjectDB.Awake)), HarmonyPostfix]
        public static void ObjectDBAwakePatchPostfix()
        {
            GameObject helmetNOrig = ObjectDB.instance.GetItemPrefab("ByzantiteHelmet");
            Renderer renderer = helmetNOrig.transform.Find("attach").Find("Helmet.003").GetComponent<Renderer>();
            renderer.enabled = false;
            helmetNOrig.GetComponent<ItemDrop>().m_itemData.m_shared.m_icons[0] = _self.helmetNIcon;

            /*Material material = renderer.material;
            material.color = new(46, 106, 120, 255);
            material.DisableKeyword("_Emission");*/

            GameObject armorNOrig = ObjectDB.instance.GetItemPrefab("ByzantiteChest");
            armorNOrig.transform.Find("attach_skin").Find("Torso.014").GetComponent<Renderer>().material = _self.chestMaterial;
            armorNOrig.GetComponent<ItemDrop>().m_itemData.m_shared.m_icons[0] = _self.armorNIcon;

            GameObject armorOOrig = ObjectDB.instance.GetItemPrefab("LokiSerpentsChest");
            armorOOrig.GetComponent<ItemDrop>().m_itemData.m_shared.m_icons[0] = _self.armorOIcon;

            GameObject legsOOrig = ObjectDB.instance.GetItemPrefab("LokiSerpentsLegs");
            legsOOrig.GetComponent<ItemDrop>().m_itemData.m_shared.m_icons[0] = _self.legsOIcon;

            GameObject helmetOOrig = ObjectDB.instance.GetItemPrefab("LokiSerpentsHelmet");
            helmetOOrig.GetComponent<ItemDrop>().m_itemData.m_shared.m_icons[0] = _self.helmetOIcon;
        }
    }
}
