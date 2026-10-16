using System.Reflection;
using HarmonyLib;
using Verse;

namespace RecordsPlus;

[StaticConstructorOnStartup]
public static class RecordsPlus
{
    static RecordsPlus()
    {
        new Harmony("Odie.BetterRecordsTab").PatchAll(Assembly.GetExecutingAssembly());
    }
}