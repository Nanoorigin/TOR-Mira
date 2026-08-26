using System;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TheOtherRoles.Roles.Crewmate;

namespace TheOtherRoles.Options.Roles.Crewmate;

public sealed class TrackerOptions : AbstractOptionGroup
{
    public override string GroupName => "Tracker";
    public override Type? OptionableType => typeof(TrackerRole);
    public override MenuCategory ParentMenu => MenuCategory.Roles;

    [ModdedNumberOption("Update Interval", 1f, 30f, 1f, MiraNumberSuffixes.Seconds)]
    public float UpdateInterval { get; set; } = 5f;

    [ModdedToggleOption("Reset Target After Meeting")]
    public bool ResetTargetAfterMeeting { get; set; } = false;

    [ModdedToggleOption("Can Track Corpses")]
    public bool CanTrackCorpses { get; set; } = true;

    [ModdedNumberOption("Corpses Cooldown", 5f, 120f, 5f, MiraNumberSuffixes.Seconds)]
    public float CorpsesCooldown { get; set; } = 30f;

    [ModdedNumberOption("Corpses Duration", 2.5f, 30f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float CorpsesDuration { get; set; } = 5f;

    [ModdedEnumOption("Tracking Method", typeof(TrackingMethodOption), ["Arrow Only", "Vents", "Distance Meter"])]
    public TrackingMethodOption TrackingMethod { get; set; } = TrackingMethodOption.ArrowOnly;
}

public enum TrackingMethodOption
{
    ArrowOnly,
    Vents,
    DistanceMeter
}
