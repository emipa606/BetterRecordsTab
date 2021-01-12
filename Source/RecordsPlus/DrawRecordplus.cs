using HarmonyLib;
using RimWorld;
using UnityEngine;
using Verse;

namespace RecordsPlus
{
    // Token: 0x02000002 RID: 2
    [HarmonyPatch(typeof(RecordsCardUtility))]
    [HarmonyPatch("DrawRecord")]
    public static class DrawRecordplus
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        private static void Prefix(float x, float y, float width, RecordDef record, Pawn pawn)
        {
            var num = pawn.records.GetValue(record);
            GUI.color = Color.white;
            foreach (Pawn pawnToTest in Find.CurrentMap.mapPawns.FreeColonists)
            {
                if (pawnToTest.records.GetValue(record) > num)
                {
                    GUI.color = Color.yellow;
                    return;
                }
            }
            if (num > 0)
            {
                GUI.color = Color.green;
            }
        }
    }
}
