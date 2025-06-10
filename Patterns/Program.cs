using Creational.Singleton;
using Creational.Prototype;
using Creational.Builder;
using Creational.AbstractFactory.Factories;
using Creational.AbstractFactory.Interfaces;
using Creational.FactoryMethod.Interfaces;
using Creational.FactoryMethod.Factories;
using Behavior.Strategy;
using Behavior.Strategy.Interfaces;
using Behavior.Strategy.AuthServices;

internal partial class Program
{
    private static void Main(string[] args)
    {
        #region Creational Patterns
        // Singleton pattern
        var config = ConfigurationManagerSingleton<DeviceInfoProvider>.Instance;
        var deviceModel = config.GetDeviceModel();

        // Prototype pattern
        var originalAndroidModel = new AndroidModel(1, "Robot A", "Model A", "Android A", "Cpu A", "Gpu A");
        var clonedAndroidModel = new AndroidModel(2, "Robot B", "Model B", "Android B", "Cpu B", "Gpu B");

        var originalRobot = new AndroidRobot(originalAndroidModel);
        originalRobot.ToString();

        var clonedRobot = originalRobot.Clone();
        clonedRobot.ToString();

        clonedRobot.SetData(clonedAndroidModel);
        clonedRobot.ToString();


        // Builder pattern
        var appSettings = new AppSettingsBuilder()
            .SetResolution(1920, 1080)
            .SetFullscreen(true)
            .SetVolume(50)
            .SetBrightness(50)
            .SetLanguage("English")
            .Build();

        var appSettings1 = new AppSettingsBuilder();
        var appSettings2 = new SettingsDirector().SetDefault(appSettings1);


        // Abstract Factory pattern
        IOsFactory osFactory = deviceModel.OperatingSystem.Contains("windows")
            ? new WindowsFactory()
            : new AppleFactory();

        osFactory.GetFileSystem().CreateDirectory("/path");
        osFactory.GetFileSystem().DeleteDirectory("/path");
        osFactory.GetAntivirusSystem().CheckIfIsSave("/path");

        //Factory Method pattern
        ApplicationCreatorBase appFactory = deviceModel.OperatingSystem.Contains("windows")
        ? new MicrosoftAppFactory()
        : new AppleAppFactory();

        appFactory.CreateApp().InstallApp();
        appFactory.CreateApp().UninstallApp();
        #endregion

        #region Structural Patterns
        // Strategic pattern
        var login = "Hell@gmail.com";

        IAuthService authService = login.Contains("@") && login.Contains(".")
            ? new EmailAuthService()
            : new PhoneAuthService();
        var isSucces = new AuthContext(authService);

        #endregion


        #region Behavioral Patterns


        #endregion


    }
}
}
