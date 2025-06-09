namespace Creational.Builder;

public class AppSettings
{
    public int ResolutionWidth { get; set; } = 1920;
    public int ResolutionHeight { get; set; } = 1080;
    public bool Fullscreen { get; set; } = true;
    public int Volume { get; set; } = 50;
    public int Brightness { get; set; } = 50;
    public string Language { get; set; } = "English";

    public override string ToString() => $"Resolution: {ResolutionWidth}x{ResolutionHeight}, Fullscreen: {Fullscreen}, Volume: {Volume}, Brightness: {Brightness}, Language: {Language}";
}
