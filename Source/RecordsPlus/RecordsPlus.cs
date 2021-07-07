using System.Reflection;
using HarmonyLib;
using Verse;

namespace RecordsPlus
{
    // Token: 0x02000003 RID: 3
    [StaticConstructorOnStartup]
    public class RecordsPlus
    {
        // Token: 0x06000002 RID: 2 RVA: 0x00002138 File Offset: 0x00000338
        static RecordsPlus()
        {
            new Harmony("com.showhair.rimworld.mod").PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}