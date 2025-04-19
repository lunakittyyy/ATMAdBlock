using HarmonyLib;

namespace ATMAdBlock.Patches
{
    [HarmonyPatch(typeof(CustomMapLoader))]
    [HarmonyPatch("ReplacePlaceholders", MethodType.Normal)]
    internal class PlaceholderPatch
    {
        private static void Prefix()
        {
            CustomMapLoader.instance.atmPrefab = null;
        }
    }
}