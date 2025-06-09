namespace Creational.Builder;

public abstract class AppSettingsBuilderBase
{
    protected AppSettings __applicationSettingsModel = null!;

    public abstract AppSettingsBuilderBase SetResolution(int width, int height);
    public abstract AppSettingsBuilderBase SetFullscreen(bool fullscreen);
    public abstract AppSettingsBuilderBase SetVolume(int volume);
    public abstract AppSettingsBuilderBase SetBrightness(int brightness);
    public abstract AppSettingsBuilderBase SetLanguage(string language);
    public abstract AppSettings Build();
}