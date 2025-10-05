using System;
using System.Collections.Generic;
using System.Text;
using MiraAPI.GameOptions;
using TheOtherRoles.CustomGameModes;
using TheOtherRoles.Options.GuesserMode;
using UnityEngine;

namespace TheOtherRoles.Utilities {
    public static class HandleGuesser {
        private static Sprite targetSprite;
        public static bool isGuesserGm = false;
        public static bool hasMultipleShotsPerMeeting = false;
        public static bool killsThroughShield = true;
        public static bool evilGuesserCanGuessSpy = true;
        public static bool guesserCantGuessSnitch = false;
        public static int tasksToUnlock = Mathf.RoundToInt(OptionGroupSingleton<GuesserGeneralSettings>.Instance.GuesserGamemodeCrewGuesserNumberOfTasks);

        public static Sprite getTargetSprite() {
            if (targetSprite) return targetSprite;
            targetSprite = TORHelpers.loadSpriteFromResources("TheOtherRoles.Resources.TargetIcon.png", 150f);
            return targetSprite;
        }

        public static bool isGuesser(byte playerId) {
            if (isGuesserGm) return GuesserGM.isGuesser(playerId);
            return Guesser.isGuesser(playerId);
        }

        public static void clear(byte playerId) {
            if (isGuesserGm) GuesserGM.clear(playerId);
            else Guesser.clear(playerId);
        }

        public static int remainingShots(byte playerId, bool shoot = false) {
            if (isGuesserGm) return GuesserGM.remainingShots(playerId, shoot);
            return Guesser.remainingShots(playerId, shoot);
        }

        public static void clearAndReload() {
            Guesser.clearAndReload();
            GuesserGM.clearAndReload();
            isGuesserGm = TORMapOptions.GameMode == CustomGamemodes.Guesser;
            if (isGuesserGm) {
                guesserCantGuessSnitch = OptionGroupSingleton<GuesserGeneralSettings>.Instance.GuesserGamemodeCantGuessSnitchIfTaksDone;
                hasMultipleShotsPerMeeting = OptionGroupSingleton<GuesserGeneralSettings>.Instance.GuesserGamemodeHasMultipleShotsPerMeeting;
                killsThroughShield = OptionGroupSingleton<GuesserGeneralSettings>.Instance.GuesserGamemodeKillsThroughShield;
                evilGuesserCanGuessSpy = OptionGroupSingleton<GuesserGeneralSettings>.Instance.GuesserGamemodeEvilCanKillSpy;
                tasksToUnlock = Mathf.RoundToInt(OptionGroupSingleton<GuesserGeneralSettings>.Instance.GuesserGamemodeCrewGuesserNumberOfTasks);
            } else {
                guesserCantGuessSnitch = CustomOptionHolder.guesserCantGuessSnitchIfTaksDone.getBool();
                hasMultipleShotsPerMeeting = CustomOptionHolder.guesserHasMultipleShotsPerMeeting.getBool();
                killsThroughShield = CustomOptionHolder.guesserKillsThroughShield.getBool();
                evilGuesserCanGuessSpy = CustomOptionHolder.guesserEvilCanKillSpy.getBool();
            }

        }
    }
}
