using GolfPlane;
using HarmonyLib;
using Sons.Gameplay;
using System;
using static RedLoader.RLog;

namespace GolfPlane
{

    [HarmonyPatch(typeof(GolfCartController), "OnDriverInteraction")]
    internal static class GolfCartControllerSettingsPatch
    {
        private static void Postfix(ref GolfCartController __instance)
        {
            if (Config.DebugOutput.Value) ReportValues(ref __instance);
            SetValues(ref __instance);
            if (Config.DebugOutput.Value) ReportValues(ref __instance);

        }

        private static void ReportValues(ref GolfCartController __instance)
        {

        }
        private static void SetValues(ref GolfCartController __instance)
        {

        }
    }
}
