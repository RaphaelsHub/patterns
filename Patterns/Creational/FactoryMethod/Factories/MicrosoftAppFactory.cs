using Creational.FactoryMethod.Interfaces;
using Creational.FactoryMethod.DownloadedApplications;

namespace Creational.FactoryMethod.Factories;

public class MicrosoftAppFactory : ApplicationCreatorBase
{
    public override IApplication CreateApp()
        => new MicrosoftApplication();
}