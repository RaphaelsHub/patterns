namespace Creational.Builder;

public class SettingsDirector
{
    public AppSettings SetDefault(AppSettingsBuilderBase builder)
    {
        return builder
            .SetLanguage("Russian")
            .SetResolution(1920, 1080)
            .SetFullscreen(true)
            .SetVolume(50)
            .SetBrightness(50)
            .Build();
    }

    public AppSettings SetVolume(AppSettingsBuilderBase builder, int volume)
    {
        return builder
            .SetVolume(volume)
            .Build();
    }
}
