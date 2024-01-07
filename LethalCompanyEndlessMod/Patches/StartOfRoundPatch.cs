using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx.Logging;
using GameNetcodeStuff;
using HarmonyLib;

namespace LethalCompanyEndlessMod.Patches
{

    [HarmonyPatch(typeof(StartOfRound))]
    internal class StartOfRoundPatch
    {
        internal ManualLogSource mls;

        [HarmonyPatch("StartGame")]
        [HarmonyPostfix]
        static void startGamePatch(ref TimeOfDay ___timeOfDay)
        {
            ManualLogSource mls = BepInEx.Logging.Logger.CreateLogSource("ZeroQuotaJimmeeX.LCTMod");
            //mls.LogInfo("[JimmeeXMod] Running PostFix StartGame");
            //mls.LogInfo(___timeOfDay);
            //mls.LogInfo(___quotaFulfilled);

            ___timeOfDay.profitQuota = 0;
            ___timeOfDay.quotaFulfilled = 0;


            //___profitQuota = 0;
            //___quotaFulfilled = 999;

            //mls.LogInfo("AFTER ---");
            //mls.LogInfo(___timeOfDay);

            //mls.LogInfo(___profitQuota);
            //mls.LogInfo(___quotaFulfilled);
        }
    }
}
