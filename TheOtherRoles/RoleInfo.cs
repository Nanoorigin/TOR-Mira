using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TheOtherRoles.Utilities;

namespace TheOtherRoles;

public class RoleInfo
{
    public Color color;
    public string name;
    public string introDescription;
    public string shortDescription;
    public RoleId roleId;
    public bool isNeutral;
    public bool isModifier;
    public bool isImpostor => color == Palette.ImpostorRed && roleId != RoleId.Spy;
    public static Dictionary<RoleId, RoleInfo> roleInfoById = new();

    public RoleInfo(string name, Color color, string introDescription, string shortDescription, RoleId roleId, bool isNeutral = false, bool isModifier = false)
    {
        this.color = color;
        this.name = name;
        this.introDescription = introDescription;
        this.shortDescription = shortDescription;
        this.roleId = roleId;
        this.isNeutral = isNeutral;
        this.isModifier = isModifier;
        roleInfoById.TryAdd(roleId, this);
    }

    // TODO: Update color references to use the new RoleColor properties from MiraAPI role classes
    public static RoleInfo jester = new RoleInfo("Jester", new Color32(236, 98, 165, 255), "Get voted out", "Get voted out", RoleId.Jester, true);
    public static RoleInfo mayor = new RoleInfo("Mayor", new Color32(32, 77, 66, 255), "Your vote counts twice", "Your vote counts twice", RoleId.Mayor);
    public static RoleInfo portalmaker = new RoleInfo("Portalmaker", new Color32(69, 69, 169, 255), "You can create portals", "You can create portals", RoleId.Portalmaker);
    public static RoleInfo engineer = new RoleInfo("Engineer", new Color32(0, 171, 139, 255), "Maintain important systems on the ship", "Repair the ship", RoleId.Engineer);
    public static RoleInfo sheriff = new RoleInfo("Sheriff", new Color32(248, 205, 70, 255), "Shoot the Impostors", "Shoot the Impostors", RoleId.Sheriff);
    public static RoleInfo deputy = new RoleInfo("Deputy", new Color32(248, 205, 70, 255), "Handcuff the Impostors", "Handcuff the Impostors", RoleId.Deputy);
    public static RoleInfo lighter = new RoleInfo("Lighter", new Color32(218, 165, 32, 255), "Your light never goes out", "Your light never goes out", RoleId.Lighter);
    public static RoleInfo godfather = new RoleInfo("Godfather", Palette.ImpostorRed, "Kill all Crewmates", "Kill all Crewmates", RoleId.Godfather);
    public static RoleInfo mafioso = new RoleInfo("Mafioso", Palette.ImpostorRed, "Work with the Mafia to kill the Crewmates", "Kill all Crewmates", RoleId.Mafioso);
    public static RoleInfo janitor = new RoleInfo("Janitor", Palette.ImpostorRed, "Work with the Mafia by hiding dead bodies", "Hide dead bodies", RoleId.Janitor);
    public static RoleInfo morphling = new RoleInfo("Morphling", Palette.ImpostorRed, "Change your look to not get caught", "Change your look", RoleId.Morphling);
    public static RoleInfo camouflager = new RoleInfo("Camouflager", Palette.ImpostorRed, "Camouflage and kill the Crewmates", "Hide among others", RoleId.Camouflager);
    public static RoleInfo vampire = new RoleInfo("Vampire", Palette.ImpostorRed, "Kill the Crewmates with your bites", "Bite your enemies", RoleId.Vampire);
    public static RoleInfo eraser = new RoleInfo("Eraser", Palette.ImpostorRed, "Kill the Crewmates and erase their roles", "Erase the roles of your enemies", RoleId.Eraser);
    public static RoleInfo trickster = new RoleInfo("Trickster", Palette.ImpostorRed, "Use your jack-in-the-boxes to surprise others", "Surprise your enemies", RoleId.Trickster);
    public static RoleInfo cleaner = new RoleInfo("Cleaner", Palette.ImpostorRed, "Kill everyone and leave no traces", "Clean up dead bodies", RoleId.Cleaner);
    public static RoleInfo warlock = new RoleInfo("Warlock", Palette.ImpostorRed, "Curse other players and kill everyone", "Curse and kill everyone", RoleId.Warlock);
    public static RoleInfo bountyHunter = new RoleInfo("Bounty Hunter", Palette.ImpostorRed, "Hunt your bounty down", "Hunt your bounty down", RoleId.BountyHunter);
    public static RoleInfo detective = new RoleInfo("Detective", new Color32(169, 110, 56, 255), "Find the Impostors by examining footprints", "Examine footprints", RoleId.Detective);
    public static RoleInfo timeMaster = new RoleInfo("Time Master", new Color32(100, 149, 237, 255), "Save yourself with your time shield", "Use your time shield", RoleId.TimeMaster);
    public static RoleInfo medic = new RoleInfo("Medic", new Color32(185, 105, 178, 255), "Protect someone with your shield", "Protect other players", RoleId.Medic);
    public static RoleInfo swapper = new RoleInfo("Swapper", new Color32(150, 110, 178, 255), "Swap votes to exile the Impostors", "Swap votes", RoleId.Swapper);
    public static RoleInfo seer = new RoleInfo("Seer", new Color32(183, 197, 220, 255), "You will see players die", "You will see players die", RoleId.Seer);
    public static RoleInfo hacker = new RoleInfo("Hacker", new Color32(34, 139, 34, 255), "Hack systems to find the Impostors", "Hack to find the Impostors", RoleId.Hacker);
    public static RoleInfo tracker = new RoleInfo("Tracker", new Color32(72, 160, 68, 255), "Track the Impostors down", "Track the Impostors down", RoleId.Tracker);
    public static RoleInfo snitch = new RoleInfo("Snitch", new Color32(184, 87, 198, 255), "Finish your tasks to find the Impostors", "Finish your tasks", RoleId.Snitch);
    public static RoleInfo jackal = new RoleInfo("Jackal", new Color32(0, 191, 255, 255), "Kill all Crewmates and Impostors to win", "Kill everyone", RoleId.Jackal, true);
    public static RoleInfo sidekick = new RoleInfo("Sidekick", new Color32(0, 191, 255, 255), "Help your Jackal to kill everyone", "Help your Jackal to kill everyone", RoleId.Sidekick, true);
    public static RoleInfo spy = new RoleInfo("Spy", new Color32(255, 128, 0, 255), "Confuse the Impostors", "Confuse the Impostors", RoleId.Spy);
    public static RoleInfo securityGuard = new RoleInfo("Security Guard", new Color32(163, 163, 163, 255), "Seal vents and place cameras", "Seal vents and place cameras", RoleId.SecurityGuard);
    public static RoleInfo arsonist = new RoleInfo("Arsonist", new Color32(255, 0, 0, 255), "Let them burn", "Let them burn", RoleId.Arsonist, true);
    public static RoleInfo goodGuesser = new RoleInfo("Nice Guesser", new Color32(255, 255, 0, 255), "Guess and shoot", "Guess and shoot", RoleId.NiceGuesser);
    public static RoleInfo badGuesser = new RoleInfo("Evil Guesser", Palette.ImpostorRed, "Guess and shoot", "Guess and shoot", RoleId.EvilGuesser);
    public static RoleInfo vulture = new RoleInfo("Vulture", new Color32(156, 113, 58, 255), "Eat corpses to win", "Eat dead bodies", RoleId.Vulture, true);
    public static RoleInfo medium = new RoleInfo("Medium", new Color32(170, 140, 190, 255), "Question the souls of the dead to gain information", "Question the souls", RoleId.Medium);
    public static RoleInfo trapper = new RoleInfo("Trapper", new Color32(110, 160, 150, 255), "Place traps to find the Impostors", "Place traps", RoleId.Trapper);
    public static RoleInfo lawyer = new RoleInfo("Lawyer", new Color32(255, 152, 37, 255), "Defend your client", "Defend your client", RoleId.Lawyer, true);
    public static RoleInfo prosecutor = new RoleInfo("Prosecutor", new Color32(255, 152, 37, 255), "Vote out your target", "Vote out your target", RoleId.Prosecutor, true);
    public static RoleInfo pursuer = new RoleInfo("Pursuer", new Color32(160, 208, 130, 255), "Blank the Impostors", "Blank the Impostors", RoleId.Pursuer);
    public static RoleInfo impostor = new RoleInfo("Impostor", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "Sabotage and kill everyone"), "Sabotage and kill everyone", RoleId.Impostor);
    public static RoleInfo crewmate = new RoleInfo("Crewmate", Color.white, "Find the Impostors", "Find the Impostors", RoleId.Crewmate);
    public static RoleInfo witch = new RoleInfo("Witch", Palette.ImpostorRed, "Cast a spell upon your foes", "Cast a spell upon your foes", RoleId.Witch);
    public static RoleInfo ninja = new RoleInfo("Ninja", Palette.ImpostorRed, "Surprise and assassinate your foes", "Surprise and assassinate your foes", RoleId.Ninja);
    public static RoleInfo thief = new RoleInfo("Thief", new Color32(110, 70, 40, 255), "Steal a killers role by killing them", "Steal a killers role", RoleId.Thief, true);
    public static RoleInfo bomber = new RoleInfo("Bomber", Palette.ImpostorRed, "Bomb all Crewmates", "Bomb all Crewmates", RoleId.Bomber);
    public static RoleInfo yoyo = new RoleInfo("Yo-Yo", Palette.ImpostorRed, "Blink to a marked location and Back", "Blink to a location", RoleId.Yoyo);
    public static RoleInfo hunter = new RoleInfo("Hunter", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "Seek and kill everyone"), "Seek and kill everyone", RoleId.Impostor);
    public static RoleInfo hunted = new RoleInfo("Hunted", Color.white, "Hide", "Hide", RoleId.Crewmate);
    public static RoleInfo prop = new RoleInfo("Prop", Color.white, "Disguise As An Object and Survive", "Disguise As An Object", RoleId.Crewmate);

    // Modifiers
    public static RoleInfo bloody = new RoleInfo("Bloody", Color.yellow, "Your killer leaves a bloody trail", "Your killer leaves a bloody trail", RoleId.Bloody, false, true);
    public static RoleInfo antiTeleport = new RoleInfo("Anti tp", Color.yellow, "You will not get teleported", "You will not get teleported", RoleId.AntiTeleport, false, true);
    public static RoleInfo tiebreaker = new RoleInfo("Tiebreaker", Color.yellow, "Your vote breaks the tie", "Break the tie", RoleId.Tiebreaker, false, true);
    public static RoleInfo bait = new RoleInfo("Bait", Color.yellow, "Bait your enemies", "Bait your enemies", RoleId.Bait, false, true);
    public static RoleInfo sunglasses = new RoleInfo("Sunglasses", Color.yellow, "You got the sunglasses", "Your vision is reduced", RoleId.Sunglasses, false, true);
    public static RoleInfo lover = new RoleInfo("Lover", new Color32(255, 128, 192, 255), "You are in love", "You are in love", RoleId.Lover, false, true);
    public static RoleInfo mini = new RoleInfo("Mini", Color.yellow, "No one will harm you until you grow up", "No one will harm you", RoleId.Mini, false, true);
    public static RoleInfo vip = new RoleInfo("VIP", Color.yellow, "You are the VIP", "Everyone is notified when you die", RoleId.Vip, false, true);
    public static RoleInfo invert = new RoleInfo("Invert", Color.yellow, "Your movement is inverted", "Your movement is inverted", RoleId.Invert, false, true);
    public static RoleInfo chameleon = new RoleInfo("Chameleon", Color.yellow, "You're hard to see when not moving", "You're hard to see when not moving", RoleId.Chameleon, false, true);
    public static RoleInfo armored = new RoleInfo("Armored", Color.yellow, "You are protected from one murder attempt", "You are protected from one murder attempt", RoleId.Armored, false, true);
    public static RoleInfo shifter = new RoleInfo("Shifter", Color.yellow, "Shift your role", "Shift your role", RoleId.Shifter, false, true);

    public static List<RoleInfo> allRoleInfos = new List<RoleInfo>()
    {
        impostor,
        godfather,
        mafioso,
        janitor,
        morphling,
        camouflager,
        vampire,
        eraser,
        trickster,
        cleaner,
        warlock,
        bountyHunter,
        witch,
        ninja,
        bomber,
        yoyo,
        goodGuesser,
        badGuesser,
        lover,
        jester,
        arsonist,
        jackal,
        sidekick,
        vulture,
        pursuer,
        lawyer,
        thief,
        prosecutor,
        crewmate,
        mayor,
        portalmaker,
        engineer,
        sheriff,
        deputy,
        lighter,
        detective,
        timeMaster,
        medic,
        swapper,
        seer,
        hacker,
        tracker,
        snitch,
        spy,
        securityGuard,
        bait,
        medium,
        trapper,
        bloody,
        antiTeleport,
        tiebreaker,
        sunglasses,
        mini,
        vip,
        invert,
        chameleon,
        armored,
        shifter
    };

    // TODO: Port getRoleInfoForPlayer to use MiraAPI's GetModdedRole() pattern instead of static player references
    public static List<RoleInfo> getRoleInfoForPlayer(PlayerControl p, bool showModifier = true)
    {
        List<RoleInfo> infos = new List<RoleInfo>();
        if (p == null) return infos;

        var moddedRole = p.GetModdedRole();

        if (moddedRole is Roles.Neutral.JesterRole) infos.Add(jester);
        else if (moddedRole is Roles.Crewmate.MayorRole) infos.Add(mayor);
        else if (moddedRole is Roles.Crewmate.PortalmakerRole) infos.Add(portalmaker);
        else if (moddedRole is Roles.Crewmate.EngineerRole) infos.Add(engineer);
        else if (moddedRole is Roles.Crewmate.SheriffRole) infos.Add(sheriff);
        else if (moddedRole is Roles.Crewmate.DeputyRole) infos.Add(deputy);
        else if (moddedRole is Roles.Crewmate.LighterRole) infos.Add(lighter);
        else if (moddedRole is Roles.Impostor.GodfatherRole) infos.Add(godfather);
        else if (moddedRole is Roles.Impostor.MafiosoRole) infos.Add(mafioso);
        else if (moddedRole is Roles.Impostor.JanitorRole) infos.Add(janitor);
        else if (moddedRole is Roles.Impostor.MorphlingRole) infos.Add(morphling);
        else if (moddedRole is Roles.Impostor.CamouflagerRole) infos.Add(camouflager);
        else if (moddedRole is Roles.Impostor.VampireRole) infos.Add(vampire);
        else if (moddedRole is Roles.Impostor.EraserRole) infos.Add(eraser);
        else if (moddedRole is Roles.Impostor.TricksterRole) infos.Add(trickster);
        else if (moddedRole is Roles.Impostor.CleanerRole) infos.Add(cleaner);
        else if (moddedRole is Roles.Impostor.WarlockRole) infos.Add(warlock);
        else if (moddedRole is Roles.Impostor.WitchRole) infos.Add(witch);
        else if (moddedRole is Roles.Impostor.NinjaRole) infos.Add(ninja);
        else if (moddedRole is Roles.Impostor.BomberRole) infos.Add(bomber);
        else if (moddedRole is Roles.Impostor.YoyoRole) infos.Add(yoyo);
        else if (moddedRole is Roles.Crewmate.DetectiveRole) infos.Add(detective);
        else if (moddedRole is Roles.Crewmate.TimeMasterRole) infos.Add(timeMaster);
        else if (moddedRole is Roles.Crewmate.MedicRole) infos.Add(medic);
        else if (moddedRole is Roles.Crewmate.SwapperRole) infos.Add(swapper);
        else if (moddedRole is Roles.Crewmate.SeerRole) infos.Add(seer);
        else if (moddedRole is Roles.Crewmate.HackerRole) infos.Add(hacker);
        else if (moddedRole is Roles.Crewmate.TrackerRole) infos.Add(tracker);
        else if (moddedRole is Roles.Crewmate.SnitchRole) infos.Add(snitch);
        else if (moddedRole is Roles.Neutral.JackalRole) infos.Add(jackal);
        else if (moddedRole is Roles.Neutral.SidekickRole) infos.Add(sidekick);
        else if (moddedRole is Roles.Crewmate.SpyRole) infos.Add(spy);
        else if (moddedRole is Roles.Crewmate.SecurityGuardRole) infos.Add(securityGuard);
        else if (moddedRole is Roles.Neutral.ArsonistRole) infos.Add(arsonist);
        else if (moddedRole is Roles.Neutral.VultureRole) infos.Add(vulture);
        else if (moddedRole is Roles.Crewmate.MediumRole) infos.Add(medium);
        else if (moddedRole is Roles.Neutral.LawyerRole) infos.Add(lawyer);
        else if (moddedRole is Roles.Neutral.PursuerRole) infos.Add(pursuer);
        else if (moddedRole is Roles.Crewmate.TrapperRole) infos.Add(trapper);
        else if (moddedRole is Roles.Neutral.ThiefRole) infos.Add(thief);

        // Default roles
        if (infos.Count == 0)
        {
            if (p.Data.Role.IsImpostor)
                infos.Add(impostor);
            else
                infos.Add(crewmate);
        }

        return infos;
    }

    public static string GetRolesString(PlayerControl p, bool useColors, bool showModifier = true, bool suppressGhostInfo = false)
    {
        string roleName;
        roleName = string.Join(" ", getRoleInfoForPlayer(p, showModifier).Select(x => useColors ? Helpers.cs(x.color, x.name) : x.name).ToArray());

        if (HandleGuesser.isGuesserGm && HandleGuesser.isGuesser(p.PlayerId))
        {
            int remainingShots = HandleGuesser.remainingShots(p.PlayerId);
            var (playerCompleted, playerTotal) = TasksHandler.taskInfo(p.Data);
            if (!Helpers.isEvil(p) && playerCompleted < HandleGuesser.tasksToUnlock || remainingShots == 0)
                roleName += Helpers.cs(Color.gray, " (Guesser)");
            else
                roleName += Helpers.cs(Color.white, " (Guesser)");
        }

        if (!suppressGhostInfo && p != null)
        {
            if (Helpers.shouldShowGhostInfo())
            {
                if (p.Data.IsDead)
                {
                    string deathReasonString = "";
                    var deadPlayer = GameHistory.deadPlayers.FirstOrDefault(x => x.player.PlayerId == p.PlayerId);

                    if (deadPlayer != null)
                    {
                        switch (deadPlayer.deathReason)
                        {
                            case DeadPlayer.CustomDeathReason.Disconnect:
                                deathReasonString = " - disconnected";
                                break;
                            case DeadPlayer.CustomDeathReason.Exile:
                                deathReasonString = " - voted out";
                                break;
                            case DeadPlayer.CustomDeathReason.Kill:
                                deathReasonString = " - killed";
                                break;
                            case DeadPlayer.CustomDeathReason.Guess:
                                deathReasonString = " - guessed";
                                break;
                            case DeadPlayer.CustomDeathReason.Shift:
                                deathReasonString = " - shifted";
                                break;
                            case DeadPlayer.CustomDeathReason.WitchExile:
                                deathReasonString = " - witched";
                                break;
                            case DeadPlayer.CustomDeathReason.LoverSuicide:
                                deathReasonString = " - lover died";
                                break;
                            case DeadPlayer.CustomDeathReason.LawyerSuicide:
                                deathReasonString = " - bad Lawyer";
                                break;
                            case DeadPlayer.CustomDeathReason.Bomb:
                                deathReasonString = " - bombed";
                                break;
                            case DeadPlayer.CustomDeathReason.Arson:
                                deathReasonString = " - burnt";
                                break;
                        }
                        roleName = roleName + deathReasonString;
                    }
                }
            }
        }
        return roleName;
    }
}

public enum RoleId
{
    None = 0,
    Crewmate,
    Impostor,
    Jester,
    Mayor,
    Portalmaker,
    Engineer,
    Sheriff,
    Deputy,
    Lighter,
    Godfather,
    Mafioso,
    Janitor,
    Detective,
    TimeMaster,
    Medic,
    Shifter,
    Swapper,
    Seer,
    Morphling,
    Camouflager,
    Hacker,
    Tracker,
    Vampire,
    Snitch,
    Jackal,
    Sidekick,
    Eraser,
    Spy,
    Trickster,
    Cleaner,
    Warlock,
    SecurityGuard,
    Arsonist,
    BountyHunter,
    Vulture,
    Medium,
    Lawyer,
    Prosecutor,
    Pursuer,
    Witch,
    Ninja,
    Thief,
    Trapper,
    Bomber,
    Yoyo,
    NiceGuesser,
    EvilGuesser,

    // Modifiers
    Bloody,
    AntiTeleport,
    Tiebreaker,
    Bait,
    Sunglasses,
    Lover,
    Mini,
    Vip,
    Invert,
    Chameleon,
    Armored,
}
