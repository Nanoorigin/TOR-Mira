using MiraAPI.Patches.Stubs;
using MiraAPI.Roles;
using UnityEngine;

namespace TheOtherRoles.Roles;

[MiraIgnore]
public abstract class NeutralRole(IntPtr cppPtr) : RoleBehaviour(cppPtr), ICustomRole
{
    public abstract string RoleName { get; }
    public abstract string RoleDescription { get; }
    public abstract string RoleLongDescription { get; }
    public abstract Color RoleColor { get; }
    public ModdedRoleTeams Team => ModdedRoleTeams.Custom;
    public CustomRoleConfiguration Configuration => new(this)
    {
        CanGetKilled = true,
        CanUseVent = false,
        CanUseSabotage = false,
        UseVanillaKillButton = false,
        TasksCountForProgress = false,
    };

    public override bool IsDead => false;
    public override bool IsAffectedByComms => false;

    public override void Initialize(PlayerControl player)
    {
        RoleBehaviourStubs.Initialize(this, player);
    }

    public override void Deinitialize(PlayerControl targetPlayer)
    {
        RoleBehaviourStubs.Deinitialize(this, targetPlayer);
    }
}
