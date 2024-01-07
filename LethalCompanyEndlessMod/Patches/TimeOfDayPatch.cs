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

    [HarmonyPatch(typeof(TimeOfDay))]
    internal class TimeOfDayPatch
    {
        internal ManualLogSource mls;

        //[HarmonyPatch(nameof(TimeOfDay.SetNewProfitQuota))]
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void zeroQuota(ref int ___profitQuota, ref int ___quotaFulfilled)
        {
            //ManualLogSource mls = BepInEx.Logging.Logger.CreateLogSource("ZeroQuotaJimmeeX.LCTMod");
            //mls.LogInfo("BEFORE ---");
            //mls.LogInfo(___profitQuota);
            //mls.LogInfo(___quotaFulfilled);


            ___profitQuota = 0;
            ___quotaFulfilled = 0;

            //mls.LogInfo("AFTER ---");
            //mls.LogInfo(___profitQuota);
            //mls.LogInfo(___quotaFulfilled);
        }
    }
}
