namespace TheOtherRoles.Utilities;

public static class FastDestroyableSingleton<T> where T : class
{
    private static T _instance;
    public static T Instance => _instance;

    public static void SetInstance(T instance)
    {
        _instance = instance;
    }
}
