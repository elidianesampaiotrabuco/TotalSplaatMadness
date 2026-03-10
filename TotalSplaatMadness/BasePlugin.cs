using BepInEx;

using HarmonyLib;

using MTM101BaldAPI;

namespace TotalSplaatMadness
{
    [BepInPlugin("sticky.bbplus.splaatvariants", "Total Splaat Madness", "0.0.1")]

    [BepInDependency("mtm101.rulerp.bbplus.baldidevapi")]

    public class BasePlugin : BaseUnityPlugin
    {
        public void Awake()
        {
            Harmony harmony = new Harmony("sticky.bbplus.splaatvariants");

            harmony.PatchAll();
        }
    }
}