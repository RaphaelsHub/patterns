namespace Creational.Singleton;

public sealed class ConfigurationManagerSingleton<T> where T : class, new()
{
    private static readonly Lazy<T> _instance =
        new Lazy<T>(() => new T());

    public static T Instance => _instance.Value;
}