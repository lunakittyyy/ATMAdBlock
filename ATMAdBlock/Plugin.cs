using BepInEx;

namespace ATMAdBlock
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Start() => HarmonyPatches.ApplyHarmonyPatches();
    }
}