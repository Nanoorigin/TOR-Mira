using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Reactor.Networking;
using Reactor.Networking.Attributes;
using Reactor.Utilities;

namespace TheOtherRoles;

[BepInPlugin("me.eisbison.theotherroles", "The Other Roles", TheOtherRolesPlugin.VersionString)]
[BepInProcess("Among Us.exe")]
[BepInDependency("mira.api")]
[ReactorModFlags(ModFlags.RequireOnAllClients)]
public partial class TheOtherRolesPlugin : BasePlugin, IMiraPlugin
{
    public const string VersionString = "5.0.0";
    public static Version Version = Version.Parse(VersionString);
    internal static BepInEx.Logging.ManualLogSource Logger = null!;

    public Harmony Harmony { get; } = new("me.eisbison.theotherroles");
    public static TheOtherRolesPlugin Instance { get; private set; } = null!;

    public string OptionsTitleText => "The Other Roles : Mira";
    public ConfigFile GetConfigFile() => Config;

    public static ConfigEntry<bool> GhostsSeeInformation { get; set; } = null!;
    public static ConfigEntry<bool> GhostsSeeRoles { get; set; } = null!;
    public static ConfigEntry<bool> GhostsSeeModifier { get; set; } = null!;
    public static ConfigEntry<bool> GhostsSeeVotes { get; set; } = null!;
    public static ConfigEntry<bool> ShowRoleSummary { get; set; } = null!;
    public static ConfigEntry<bool> EnableSoundEffects { get; set; } = null!;
    public static ConfigEntry<bool> ShowVentsOnMap { get; set; } = null!;
    public static ConfigEntry<bool> ShowChatNotifications { get; set; } = null!;

    public override void Load()
    {
        Logger = Log;
        Instance = this;

        ReactorCredits.Register("The Other Roles: Mira", VersionString, true, ReactorCredits.AlwaysShow);

        GhostsSeeInformation = Config.Bind("Custom", "Ghosts See Remaining Tasks", true);
        GhostsSeeRoles = Config.Bind("Custom", "Ghosts See Roles", true);
        GhostsSeeModifier = Config.Bind("Custom", "Ghosts See Modifier", true);
        GhostsSeeVotes = Config.Bind("Custom", "Ghosts See Votes", true);
        ShowRoleSummary = Config.Bind("Custom", "Show Role Summary", true);
        EnableSoundEffects = Config.Bind("Custom", "Enable Sound Effects", true);
        ShowVentsOnMap = Config.Bind("Custom", "Show vent positions on minimap", false);
        ShowChatNotifications = Config.Bind("Custom", "Show Chat Notifications", true);

        Harmony.PatchAll();
        Logger.LogInfo("The Other Roles (MiraAPI) loaded successfully!");
    }
}
