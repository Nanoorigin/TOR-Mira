using System;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Crewmate;

namespace TheOtherRoles.Options.Roles.Crewmate;

public sealed class SeerOptions : AbstractOptionGroup
{
    public override string GroupName => "Seer";
    public override Type? OptionableType => typeof(SeerRole);
    public override MenuCategory ParentMenu => MenuCategory.Roles;

    [ModdedToggleOption("Limit Soul Duration")]
    public bool LimitSoulDuration { get; set; } = false;

    [ModdedNumberOption("Soul Duration", 0f, 120f, 5f, MiraNumberSuffixes.Seconds)]
    public float SoulDuration { get; set; } = 15f;
}
