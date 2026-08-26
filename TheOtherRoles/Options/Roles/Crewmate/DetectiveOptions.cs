using System;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Crewmate;

namespace TheOtherRoles.Options.Roles.Crewmate;

public sealed class DetectiveOptions : AbstractOptionGroup
{
    public override string GroupName => "Detective";
    public override Type? OptionableType => typeof(DetectiveRole);
    public override MenuCategory ParentMenu => MenuCategory.Roles;

    [ModdedToggleOption("Anonymous Footprints")]
    public bool AnonymousFootprints { get; set; } = false;

    [ModdedNumberOption("Footprint Interval", 0.25f, 10f, 0.25f, MiraNumberSuffixes.Seconds)]
    public float FootprintIntervall { get; set; } = 0.5f;

    [ModdedNumberOption("Footprint Duration", 0.25f, 10f, 0.25f, MiraNumberSuffixes.Seconds)]
    public float FootprintDuration { get; set; } = 5f;

    [ModdedNumberOption("Report Name Duration", 0f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float ReportNameDuration { get; set; } = 0f;

    [ModdedNumberOption("Report Color Duration", 0f, 120f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float ReportColorDuration { get; set; } = 20f;
}
