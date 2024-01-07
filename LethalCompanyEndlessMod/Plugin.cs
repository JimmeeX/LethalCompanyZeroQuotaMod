using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using LethalCompanyEndlessMod.Patches;

namespace LethalCompanyEndlessMod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class ZeroQuotaModBase: BaseUnityPlugin
    {
        private const string modGUID = "ZeroQuotaJimmeeX.LCTMod";
        private const string modName = "Zero Quota Mod";
        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static ZeroQuotaModBase Instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);
            mls.LogInfo("Installing ZeroQuotaModBase! :)");

            harmony.PatchAll(typeof(ZeroQuotaModBase));
            // harmony.PatchAll(typeof(PlayerControllerBPatch));
            harmony.PatchAll(typeof(TimeOfDayPatch));
        }
    }
}
