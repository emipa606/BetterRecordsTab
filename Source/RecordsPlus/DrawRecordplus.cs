using HarmonyLib;
using RimWorld;
using UnityEngine;
using Verse;

namespace RecordsPlus;

[HarmonyPatch(typeof(RecordsCardUtility), "DrawRecord")]
public static class DrawRecordplus
{
    private static void Prefix(RecordDef record, Pawn pawn)
    {
        var num = pawn.records.GetValue(record);
        GUI.color = Color.white;
        foreach (var pawnToTest in Find.CurrentMap.mapPawns.FreeColonists)
        {
            if (!(pawnToTest.records.GetValue(record) > num))
            {
                continue;
            }

            GUI.color = Color.yellow;
            return;
        }

        if (num > 0)
        {
            GUI.color = Color.green;
        }
    }
}