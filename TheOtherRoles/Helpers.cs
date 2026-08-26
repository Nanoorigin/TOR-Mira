using System;
using System.Collections;
using System.Linq.Expressions;
using UnityEngine;

namespace TheOtherRoles;

public static class Helpers
{
    public static System.Random rnd = new((int)DateTime.Now.Ticks);

    public static Sprite loadSpriteFromResources(string path, float pixelsPerUnit)
    {
        try
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream(path);
            if (stream == null) return null;
            var texture = new Texture2D(1, 1, TextureFormat.RGBA32, false);
            var data = new byte[stream.Length];
            _ = stream.Read(data, 0, (int)stream.Length);
            _ = texture.LoadImage(data);
            return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), pixelsPerUnit);
        }
        catch
        {
            return null;
        }
    }

    public static void setDefaultLook(this PlayerControl player)
    {
        if (player == null) return;
        player.cosmetics.nameText.text = player.Data.PlayerName;
        player.cosmetics.SetEnabledColorblind(false);
    }

    public static bool isKillable(this PlayerControl player)
    {
        return player != null && !player.Data.Disconnected && !player.Data.IsDead;
    }

    public static ICustomRole GetModdedRole(this PlayerControl player)
    {
        if (player?.Data?.Role == null) return null;
        return player.Data.Role as ICustomRole;
    }

    public static bool shouldShowGhostInfo()
    {
        return PlayerControl.LocalPlayer.Data.IsDead && TheOtherRolesPlugin.GhostsSeeInformation.Value;
    }

    public static PlayerControl GetClosestPlayer(this PlayerControl player, float maxDistance = float.MaxValue)
    {
        PlayerControl closest = null;
        float closestDistance = maxDistance;
        foreach (var p in PlayerControl.AllPlayerControls)
        {
            if (p == player || p.Data.IsDead || p.Data.Disconnected) continue;
            float dist = Vector2.Distance(player.transform.position, p.transform.position);
            if (dist < closestDistance)
            {
                closestDistance = dist;
                closest = p;
            }
        }
        return closest;
    }

    public static List<PlayerControl> GetAlivePlayers()
    {
        var players = new List<PlayerControl>();
        foreach (var p in PlayerControl.AllPlayerControls)
        {
            if (!p.Data.Disconnected && !p.Data.IsDead) players.Add(p);
        }
        return players;
    }

    public static string cs(Color c, string s)
    {
        return string.Format("<color=#{0:X2}{1:X2}{2:X2}{3:X2}>{4}</color>", ToByte(c.r), ToByte(c.g), ToByte(c.b), ToByte(c.a), s);
    }

    private static byte ToByte(float f)
    {
        f = Mathf.Clamp01(f);
        return (byte)(f * 255);
    }

    public static bool isEvil(PlayerControl player)
    {
        return player.Data.Role.IsImpostor;
    }

    public static bool isNeutral(PlayerControl player)
    {
        return player.GetModdedRole() is Roles.NeutralRole;
    }

    public static KeyValuePair<byte, int> MaxPair(this Dictionary<byte, int> self, out bool tie)
    {
        tie = true;
        KeyValuePair<byte, int> result = new KeyValuePair<byte, int>(byte.MaxValue, int.MinValue);
        foreach (KeyValuePair<byte, int> keyValuePair in self)
        {
            if (keyValuePair.Value > result.Value)
            {
                result = keyValuePair;
                tie = false;
            }
            else if (keyValuePair.Value == result.Value)
            {
                tie = true;
            }
        }
        return result;
    }

    public static bool hasAliveKillingLover(this PlayerControl player)
    {
        // TODO: Implement when Lovers modifier is fully ported
        return false;
    }

    public static System.Collections.Generic.IEnumerable<T> GetFastEnumerator<T>(this Il2CppSystem.Collections.Generic.List<T> list) where T : Il2CppSystem.Object
        => new Il2CppListEnumerable<T>(list);
}

public unsafe class Il2CppListEnumerable<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IEnumerator<T> where T : Il2CppSystem.Object
{
    private struct Il2CppListStruct
    {
#pragma warning disable CS0169
        private IntPtr _unusedPtr1;
        private IntPtr _unusedPtr2;
#pragma warning restore CS0169

#pragma warning disable CS0649
        public IntPtr _items;
        public int _size;
#pragma warning restore CS0649
    }

    private static readonly int _elemSize;
    private static readonly int _offset;
    private static Func<IntPtr, T> _objFactory;

    static Il2CppListEnumerable()
    {
        _elemSize = IntPtr.Size;
        _offset = 4 * IntPtr.Size;

        var constructor = typeof(T).GetConstructor(new[] { typeof(IntPtr) });
        var ptr = Expression.Parameter(typeof(IntPtr));
        var create = Expression.New(constructor!, ptr);
        var lambda = Expression.Lambda<Func<IntPtr, T>>(create, ptr);
        _objFactory = lambda.Compile();
    }

    private readonly IntPtr _arrayPointer;
    private readonly int _count;
    private int _index = -1;

    public Il2CppListEnumerable(Il2CppSystem.Collections.Generic.List<T> list)
    {
        var listStruct = (Il2CppListStruct*)list.Pointer;
        _count = listStruct->_size;
        _arrayPointer = listStruct->_items;
    }

    object IEnumerator.Current => Current;
    public T Current { get; private set; }

    public bool MoveNext()
    {
        if (++_index >= _count) return false;
        var refPtr = *(IntPtr*)IntPtr.Add(IntPtr.Add(_arrayPointer, _offset), _index * _elemSize);
        Current = _objFactory(refPtr);
        return true;
    }

    public void Reset()
    {
        _index = -1;
    }

    public System.Collections.Generic.IEnumerator<T> GetEnumerator()
    {
        return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this;
    }

    public void Dispose()
    {
    }
}
