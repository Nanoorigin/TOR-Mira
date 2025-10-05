global using Il2CppInterop.Runtime;
global using Il2CppInterop.Runtime.Attributes;
global using Il2CppInterop.Runtime.Injection;
global using Il2CppInterop.Runtime.InteropTypes;
global using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using AmongUs.Data;
using AmongUs.Data.Player;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using MiraAPI;
using MiraAPI.PluginLoading;
using Reactor;
using Reactor.Networking.Attributes;
using Reactor.Utilities;
using TheOtherRoles.Modules;
using TheOtherRoles.Modules.CustomHats;
using TheOtherRoles.Patches;
using TheOtherRoles.Utilities;

namespace TheOtherRoles
{
    [BepInPlugin(Id, "The Other Roles Mira", VersionString)]
    [BepInDependency(ReactorPlugin.Id)]
    [BepInDependency(MiraApiPlugin.Id)]
    [BepInProcess("Among Us.exe")]
    [BepInDependency(SubmergedCompatibility.SUBMERGED_GUID, BepInDependency.DependencyFlags.SoftDependency)]
    [ReactorModFlags(Reactor.Networking.ModFlags.RequireOnAllClients)]
    
    public class TheOtherRolesPlugin : BasePlugin, IMiraPlugin
    {
        public const string Id = "tor.miraapi.amongus";
        public const string VersionString = "1.0.0";
        public static uint betaDays = 2;  // amount of days for the build to be usable (0 for infinite!)

        public static Version Version = Version.Parse(VersionString);
        internal static BepInEx.Logging.ManualLogSource Logger;
         
        public Harmony Harmony { get; } = new Harmony(Id);
        public static TheOtherRolesPlugin Instance;

        public static int optionsPage = 2;

        public static ConfigEntry<string> DebugMode { get; private set; }
        public static ConfigEntry<bool> GhostsSeeInformation { get; set; }
        public static ConfigEntry<bool> GhostsSeeRoles { get; set; }
        public static ConfigEntry<bool> GhostsSeeModifier { get; set; }
        public static ConfigEntry<bool> GhostsSeeVotes{ get; set; }
        public static ConfigEntry<bool> ShowRoleSummary { get; set; }
        public static ConfigEntry<bool> ShowLighterDarker { get; set; }
        public static ConfigEntry<bool> EnableSoundEffects { get; set; }
        public static ConfigEntry<bool> ShowVentsOnMap { get; set; }
        public static ConfigEntry<bool> ShowChatNotifications { get; set; }
        public static ConfigEntry<string> ShowPopUpVersion { get; set; }

        public string OptionsTitleText => "TOR Mira";
        public ConfigFile GetConfigFile() => Config;

        public override void Load() {
            Logger = Log;
            Instance = this;
  
            _ = TORHelpers.checkBeta(); // Exit if running an expired beta
            _ = Patches.CredentialsPatch.MOTD.loadMOTDs();

            DebugMode = Config.Bind("Custom", "Enable Debug Mode", "false");
            GhostsSeeInformation = Config.Bind("Custom", "Ghosts See Remaining Tasks", true);
            GhostsSeeRoles = Config.Bind("Custom", "Ghosts See Roles", true);
            GhostsSeeModifier = Config.Bind("Custom", "Ghosts See Modifier", true);
            GhostsSeeVotes = Config.Bind("Custom", "Ghosts See Votes", true);
            ShowRoleSummary = Config.Bind("Custom", "Show Role Summary", true);
            ShowLighterDarker = Config.Bind("Custom", "Show Lighter / Darker", true);
            EnableSoundEffects = Config.Bind("Custom", "Enable Sound Effects", true);
            ShowPopUpVersion = Config.Bind("Custom", "Show PopUp", "0");
            ShowVentsOnMap = Config.Bind("Custom", "Show vent positions on minimap", false);
            ShowChatNotifications = Config.Bind("Custom", "Show Chat Notifications", true);

            // Removes vanilla Servers
            ServerManager.DefaultRegions = new Il2CppReferenceArray<IRegionInfo>(new IRegionInfo[0]);

            // Reactor Credits
            ReactorCredits.Register("The Other Roles: Mira", Version.ToString(), betaDays > 0, location => location == Reactor.Utilities.ReactorCredits.Location.PingTracker);

            DebugMode = Config.Bind("Custom", "Enable Debug Mode", "false");
            Harmony.PatchAll();
            
            CustomOptionHolder.Load();
            CustomColors.Load();
            CustomHatManager.LoadHats();
            if (BepInExUpdater.UpdateRequired)
            {
                AddComponent<BepInExUpdater>();
                return;
            }

            AddComponent<ModUpdater>();

            EventUtility.Load();
            SubmergedCompatibility.Initialize();
            MainMenuPatch.addSceneChangeCallbacks();
            _ = RoleInfo.loadReadme();
            AddToKillDistanceSetting.addKillDistance();
            TheOtherRolesPlugin.Logger.LogInfo("Loading TOR Mira completed!");
        }
    }

    // Deactivate bans, since I always leave my local testing game and ban myself
    [HarmonyPatch(typeof(PlayerBanData), nameof(PlayerBanData.IsBanned), MethodType.Getter)]
    public static class IsBannedPatch
    {
        public static void Postfix(out bool __result)
        {
            __result = false;
        }
    }

    [HarmonyPatch(typeof(ChatController), nameof(ChatController.Awake))]
    public static class ChatControllerAwakePatch {
        private static void Prefix() {
            if (!EOSManager.Instance.isKWSMinor) {
                DataManager.Settings.Multiplayer.ChatMode = InnerNet.QuickChatModes.FreeChatOrQuickChat;
            }
        }
    }
}
