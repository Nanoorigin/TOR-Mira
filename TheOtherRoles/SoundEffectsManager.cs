using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using UnityEngine;

namespace TheOtherRoles;

public static class SoundEffectsManager
{
    private static Dictionary<string, AudioClip> soundEffects = new();

    public static void Load()
    {
        soundEffects = new Dictionary<string, AudioClip>();
        Assembly assembly = Assembly.GetExecutingAssembly();
        string[] resourceNames = assembly.GetManifestResourceNames();

        var resourceBundle = assembly.GetManifestResourceStream("TheOtherRoles.Resources.SoundEffects.toraudio");
        if (resourceBundle == null) return;

        using var ms = new MemoryStream();
        resourceBundle.CopyTo(ms);
        var assetBundle = AssetBundle.LoadFromMemory(ms.ToArray());
        if (assetBundle == null) return;

        foreach (var f in assetBundle.GetAllAssetNames())
        {
            var obj = assetBundle.LoadAsset(f);
            var clip = obj as AudioClip;
            if (clip != null)
                soundEffects.Add(f, clip);
        }
        assetBundle.Unload(false);
    }

    public static AudioClip get(string path)
    {
        if (!path.Contains("assets")) path = "assets/audio/" + path.ToLower() + ".ogg";
        AudioClip returnValue;
        return soundEffects.TryGetValue(path, out returnValue) ? returnValue : null;
    }

    public static AudioSource play(string path, float volume = 0.8f, bool loop = false, bool musicChannel = false)
    {
        if (!TORMapOptions.enableSoundEffects) return null;
        AudioClip clipToPlay = get(path);
        stop(path);
        if (Constants.ShouldPlaySfx() && clipToPlay != null)
        {
            AudioSource source = SoundManager.Instance.PlaySound(clipToPlay, false, volume, audioMixer: musicChannel ? SoundManager.Instance.MusicChannel : null);
            source.loop = loop;
            return source;
        }
        return null;
    }

    public static void stop(string path)
    {
        var soundToStop = get(path);
        if (soundToStop != null)
        {
            try
            {
                SoundManager.Instance?.StopSound(soundToStop);
            }
            catch (Exception e)
            {
                TheOtherRolesPlugin.Logger.LogWarning($"Exception in stop sound: {e}");
            }
        }
    }

    public static void stopAll()
    {
        if (soundEffects == null) return;
        try
        {
            foreach (var path in soundEffects.Keys)
            {
                stop(path);
            }
        }
        catch { }
    }
}
