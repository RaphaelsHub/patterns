namespace Creational.Builder;

public class AppSettingsBuilder : AppSettingsBuilderBase
{
    public AppSettingsBuilder() => __applicationSettingsModel = new AppSettings();

    public override string ToString()
    {
        return __applicationSettingsModel.ToString();
    }

    public override AppSettingsBuilderBase SetResolution(int width, int height)
    {
        __applicationSettingsModel.ResolutionWidth = width;
        __applicationSettingsModel.ResolutionHeight = height;
        return this;
    }

    public override AppSettingsBuilderBase SetFullscreen(bool fullscreen)
    {
        __applicationSettingsModel.Fullscreen = fullscreen;
        return this;
    }

    public override AppSettingsBuilderBase SetVolume(int volume)
    {
        __applicationSettingsModel.Volume = volume;
        return this;
    }

    public override AppSettingsBuilderBase SetBrightness(int brightness)
    {
        __applicationSettingsModel.Brightness = brightness;
        return this;
    }

    public override AppSettingsBuilderBase SetLanguage(string language)
    {
        __applicationSettingsModel.Language = language;
        return this;
    }

    public override AppSettings Build() => __applicationSettingsModel;
}