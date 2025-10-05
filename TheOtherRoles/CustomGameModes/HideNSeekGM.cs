using System;
using System.Collections.Generic;
using MiraAPI.GameOptions;
using TheOtherRoles.Objects;
using TheOtherRoles.Options.HideNSeek;
using UnityEngine;

namespace TheOtherRoles.CustomGameModes {
    public static class HideNSeek { // HideNSeek Gamemode
        public static bool isHideNSeekGM = false;
        public static TMPro.TMP_Text timerText = null;
        public static Vent polusVent = null;
        public static bool isWaitingTimer = true;
        public static DateTime startTime = DateTime.UtcNow;

        public static float timer = 300f;
        public static float hunterVision = 0.5f;
        public static float huntedVision = 2f;
        public static bool taskWinPossible = false;
        public static float taskPunish = 10f;
        public static int impNumber = 2;
        public static bool canSabotage = false;
        public static float killCooldown = 10f;
        public static float hunterWaitingTime = 15f;
        public static bool isHunter() {
            return isHideNSeekGM && PlayerControl.LocalPlayer != null && PlayerControl.LocalPlayer.Data.Role.IsImpostor;
        }

        public static List<PlayerControl> getHunters() {
            List<PlayerControl> hunters = new List<PlayerControl>(PlayerControl.AllPlayerControls.ToArray());
            hunters.RemoveAll(x => !x.Data.Role.IsImpostor);
            return hunters;
        }

        public static bool isHunted() {
            return isHideNSeekGM && PlayerControl.LocalPlayer != null && !PlayerControl.LocalPlayer.Data.Role.IsImpostor;
        }

        public static void clearAndReload() {
            isHideNSeekGM = TORMapOptions.GameMode == CustomGamemodes.HideNSeek;
            if (timerText != null) UnityEngine.Object.Destroy(timerText);
            timerText = null;
            if (polusVent != null) UnityEngine.Object.Destroy(polusVent);
            polusVent = null;
            isWaitingTimer = true;
            startTime = DateTime.UtcNow;

            timer = OptionGroupSingleton<GeneralHideNSeekSettings>.Instance.HideNSeekTimer * 60;
            hunterVision = OptionGroupSingleton<GeneralHideNSeekSettings>.Instance.HideNSeekHunterVision;
            huntedVision = OptionGroupSingleton<GeneralHideNSeekSettings>.Instance.HideNSeekHuntedVision;
            taskWinPossible = OptionGroupSingleton<GeneralHideNSeekSettings>.Instance.HideNSeekTaskWin;
            taskPunish = OptionGroupSingleton<GeneralHideNSeekSettings>.Instance.HideNSeekTaskPunish;
            impNumber = Mathf.RoundToInt(OptionGroupSingleton<GeneralHideNSeekSettings>.Instance.HideNSeekHunterCount);
            canSabotage = OptionGroupSingleton<GeneralHideNSeekSettings>.Instance.HideNSeekCanSabotage;
            killCooldown = OptionGroupSingleton<GeneralHideNSeekSettings>.Instance.HideNSeekKillCooldown;
            hunterWaitingTime = OptionGroupSingleton<GeneralHideNSeekSettings>.Instance.HideNSeekHunterWaiting;

            Hunter.clearAndReload();
            Hunted.clearAndReload();
        }
    }

    public static class Hunter {
        public static List<Arrow> localArrows = new List<Arrow>();
        public static List<byte> lightActive = new List<byte>();
        public static bool arrowActive = false;
        public static Dictionary<byte, int> playerKillCountMap = new Dictionary<byte, int>();

        public static float lightCooldown = 30f;
        public static float lightDuration = 5f;
        public static float lightVision = 2f;
        public static float lightPunish = 5f;
        public static float AdminCooldown = 30f;
        public static float AdminDuration = 5f;
        public static float AdminPunish = 5f;
        public static float ArrowCooldown = 30f;
        public static float ArrowDuration = 5f;
        public static float ArrowPunish = 5f;
        private static Sprite buttonSpriteLight;
        private static Sprite buttonSpriteArrow;

        public static bool isLightActive (byte playerId) {
            return lightActive.Contains(playerId);
        }

        public static Sprite getArrowSprite() {
            if (buttonSpriteArrow) return buttonSpriteArrow;
            buttonSpriteArrow = TORHelpers.loadSpriteFromResources("TheOtherRoles.Resources.HideNSeekArrowButton.png", 115f);
            return buttonSpriteArrow;
        }

        public static Sprite getLightSprite() {
            if (buttonSpriteLight) return buttonSpriteLight;
            buttonSpriteLight = TORHelpers.loadSpriteFromResources("TheOtherRoles.Resources.LighterButton.png", 115f);
            return buttonSpriteLight;
        }

        public static void clearAndReload() {
            if (localArrows != null) {
                foreach (Arrow arrow in localArrows)
                    if (arrow?.arrow != null)
                        UnityEngine.Object.Destroy(arrow.arrow);
            }
            localArrows = new List<Arrow>();
            lightActive = new List<byte>();
            arrowActive = false;

            lightCooldown = OptionGroupSingleton<HunterRolesSettings>.Instance.HunterLightCooldown;
            lightDuration = OptionGroupSingleton<HunterRolesSettings>.Instance.HunterLightDuration;
            lightVision = OptionGroupSingleton<HunterRolesSettings>.Instance.HunterLightVision;
            lightPunish = OptionGroupSingleton<HunterRolesSettings>.Instance.HunterLightPunish;
            AdminCooldown = OptionGroupSingleton<HunterRolesSettings>.Instance.HunterAdminCooldown;
            AdminDuration = OptionGroupSingleton<HunterRolesSettings>.Instance.HunterAdminDuration;
            AdminPunish = OptionGroupSingleton<HunterRolesSettings>.Instance.HunterAdminPunish;
            ArrowCooldown = OptionGroupSingleton<HunterRolesSettings>.Instance.HunterArrowCooldown;
            ArrowDuration = OptionGroupSingleton<HunterRolesSettings>.Instance.HunterArrowDuration;
            ArrowPunish = OptionGroupSingleton<HunterRolesSettings>.Instance.HunterArrowPunish;
        }
    }

    public static class Hunted {
        public static List<byte> timeshieldActive = new List<byte>();
        public static int shieldCount = 3;

        public static float shieldCooldown = 30f;
        public static float shieldDuration = 5f;
        public static float shieldRewindTime = 3f;
        public static bool taskPunish = false;
        public static void clearAndReload() {
            timeshieldActive = new List<byte>();
            taskPunish = false;

            shieldCount = Mathf.RoundToInt(OptionGroupSingleton<HuntedShieldSettings>.Instance.HuntedShieldNumber);
            shieldCooldown = OptionGroupSingleton<HuntedShieldSettings>.Instance.HuntedShieldCooldown;
            shieldDuration = OptionGroupSingleton<HuntedShieldSettings>.Instance.HuntedShieldDuration;
            shieldRewindTime = OptionGroupSingleton<HuntedShieldSettings>.Instance.HuntedShieldRewindTime;
        }
    }
}