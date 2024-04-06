using Microsoft.Extensions.Options;

namespace IOptionsProject;

public class Program
{
 
    static void Main(string[] args)
    {


        Program program = new Program();
        program.DemoIOptions();

    }
}

public class DemoIOptions
{
    private readonly AppSettings _appSettings;

    public DemoIOptions(IOptions<AppSettings> appSettings) => _appSettings = appSettings.Value;

    void TestIOptions()
    {
        var appName = _appSettings.AppName;
        var appVersion = _appSettings.AppVersion;

        Console.WriteLine("App Name: " + appName);
        Console.WriteLine("App Version: " + appVersion);
    }

}
