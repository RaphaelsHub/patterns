using Creational.FactoryMethod.Interfaces;
using Creational.FactoryMethod.DownloadedApplications;

namespace Creational.FactoryMethod.Factories;

public class AppleAppFactory : ApplicationCreatorBase
{
    public override IApplication CreateApp() =>
        new AppleApplication();
}