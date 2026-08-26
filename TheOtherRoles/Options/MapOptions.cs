using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;

namespace TheOtherRoles.Options;

public sealed class MapOptions : AbstractOptionGroup
{
    public override string GroupName => "Map";

    [ModdedToggleOption("Dynamic Map Selection")]
    public bool DynamicMap { get; set; } = false;

    [ModdedToggleOption("Enable Skeld")]
    public bool EnableSkeld { get; set; } = true;

    [ModdedToggleOption("Enable Mira HQ")]
    public bool EnableMiraHQ { get; set; } = true;

    [ModdedToggleOption("Enable Polus")]
    public bool EnablePolus { get; set; } = true;

    [ModdedToggleOption("Enable Airship")]
    public bool EnableAirship { get; set; } = true;

    [ModdedToggleOption("Enable Fungle")]
    public bool EnableFungle { get; set; } = true;
}
