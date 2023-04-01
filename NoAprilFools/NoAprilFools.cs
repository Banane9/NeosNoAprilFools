using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using BaseX;
using CodeX;
using FrooxEngine;
using FrooxEngine.LogiX;
using FrooxEngine.LogiX.Data;
using FrooxEngine.LogiX.ProgramFlow;
using FrooxEngine.UIX;
using HarmonyLib;
using NeosModLoader;

namespace NoAprilFools
{
    public class NoAprilFools : NeosMod
    {
        public override string Author => "Banane9";
        public override string Link => "https://github.com/Banane9/NeosNoAprilFools";
        public override string Name => "NoAprilFools";
        public override string Version => "1.0.0";

        public override void OnEngineInit()
        {
            var harmony = new Harmony($"{Author}.{Name}");
            harmony.PatchAll();
        }

        [HarmonyPatch(typeof(Engine))]
        private static class EnginePatch
        {
            [HarmonyPrefix]
            [HarmonyPatch(nameof(Engine.IsAprilFools))]
            private static bool IsAprilFoolsPrefix(ref bool __result)
            {
                __result = false;
                return false;
            }
        }
    }
}