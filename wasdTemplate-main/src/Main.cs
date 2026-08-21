using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using Polytopia;
using Polytopia.Data;
using PolytopiaBackendBase.Common;

namespace wasdTemplate;

public static class Main
{
    public static ManualLogSource modLogger;
    public static void Load(ManualLogSource logger)
    {
        modLogger = logger;
        modLogger.LogInfo("wasdtemplate");
        Harmony.CreateAndPatchAll(typeof(Main));
    }
}
