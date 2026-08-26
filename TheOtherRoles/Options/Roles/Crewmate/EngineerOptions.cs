using System;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Crewmate;

namespace TheOtherRoles.Options.Roles.Crewmate;

public sealed class EngineerOptions : AbstractOptionGroup
{
    public override string GroupName => "Engineer";
    public override Type? OptionableType => typeof(EngineerRole);
    public override MenuCategory ParentMenu => MenuCategory.Roles;

    [ModdedNumberOption("Number Of Fixes", 1f, 3f, 1f, MiraNumberSuffixes.None)]
    public float NumberOfFixes { get; set; } = 1f;

    [ModdedToggleOption("Impostors See Vents")]
    public bool ImpostorsSeeVents { get; set; } = true;

    [ModdedToggleOption("Jackal Sees Vents")]
    public bool JackalSeesVents { get; set; } = true;
}
