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
using Behavior.ChainOfResponsibility.Model;
using Behavior.ChainOfResponsibility.Abstractions;
using Behavior.ChainOfResponsibility.ValidionsHandlers;
using System.Windows.Input;
using Behavior.Command;
using Behavior.State;
using Behavior.Mediatr;
using Structural.Adapter;
using Structural.Bridge;

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


        // Chain of Responsibility pattern
        var booking = new BookingModel("Alex", 100.4m);
        BookingSaveHandlerBase handlerBase = new ValidateCustomerNameHandler();
        BookingSaveHandlerBase nextHandler = new ValidatePriceHandler();
        handlerBase.SetNext(nextHandler);
        var isValid = handlerBase.Handle(booking);


        // Command pattern
        Behavior.Command.ICommand createBookingCommand = new CreateBookingCommand(booking);
        createBookingCommand.Execute();

        Behavior.Command.ICommand deleteBookingCommand = new DeleteBookingCommand(booking);
        deleteBookingCommand.Execute();


        // State pattern
        IFlightState state = new PlannedState();
        var flightContext = new FlightStateContext();
        flightContext.SetState(state);
        Console.WriteLine(flightContext.GetStatus());
        Console.WriteLine(flightContext.CanEdit());

        // Observer pattern
        var bookingObserver = new Behavior.Observer.BookingObserver();
        bookingObserver.Subscribe(new Behavior.Observer.LoggingBookingNotificationService());
        bookingObserver.Subscribe(new Behavior.Observer.EmailBookingNotificationService());
        bookingObserver.Notify(booking);

        // Mediator pattern
        var mediator = new Mediator();
        mediator.RegisterHandler<GetTimeQuery, string>(new GetTimeHandler());
        var result = mediator.Send<GetTimeQuery, string>(new GetTimeQuery());
        Console.WriteLine(result);

        #endregion

        #region Behavioral Patterns
        // Adapter pattern
        IEmailService emailService = new EmailAdapter(new ExternalMailSender());
        emailService.SendEmail("daddy", "Hello", "This is a test email").Wait();

        // Bridge pattern
        TechDeviceBase techDeviceBase = new RemoteDeviceControl(new PhoneDevice());
        techDeviceBase.TurnOn();
        techDeviceBase.TurnOff();

        if (techDeviceBase is RemoteDeviceControl remoteDeviceControl)
        {
            remoteDeviceControl.SetDevice(new TvDevice());
        }
        else
        {
            throw new InvalidOperationException("Invalid device type");
        }

        remoteDeviceControl.TurnOn();
        remoteDeviceControl.TurnOff();

        // Composite pattern
        var folder = new Structural.Composite.Folder("Root Folder");
        folder.Add(new Structural.Composite.File("File1.txt"));
        folder.Add(new Structural.Composite.File("File2.txt"));
        var subFolder = new Structural.Composite.Folder("Sub Folder");
        subFolder.Add(new Structural.Composite.File("File3.txt"));
        folder.Add(subFolder);
        folder.Display();
        
        #endregion
    }
}
}
