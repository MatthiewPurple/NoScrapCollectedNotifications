using HarmonyLib;

namespace NoScrapCollectedNotifications.Patches
{
    [HarmonyPatch(typeof(HUDManager), "AddNewScrapFoundToDisplay")]
    public class AddNewScrapFoundToDisplay
    {
        // Before the games adds a scrap to the list of items to display as a notification
        private static bool Prefix(StartOfRound __instance)
        {
            return false;   // Skips the vanilla method
        }
    }
}