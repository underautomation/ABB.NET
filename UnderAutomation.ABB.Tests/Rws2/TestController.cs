using UnderAutomation.ABB.Tests.Rws2;
using static UnderAutomation.ABB.Tests.Rws2.TestHelper;

/// <summary>
/// Test: ControllerService — GetIdentity, GetDateTime, GetEnvironmentVariable
/// </summary>
class TestController
{
    public static void Run()
    {
        var client = Connect();

        Try("GetIdentity", () =>
        {
            var identity = client.ControllerService.GetIdentity();
            Console.WriteLine($"  Name     : {identity.Name}");
            Console.WriteLine($"  Type     : {identity.Type}");
            Console.WriteLine($"  MAC      : {identity.MacAddress}");
        });

        Try("GetDateTime", () =>
        {
            var dt = client.ControllerService.GetDateTime();
            Console.WriteLine($"  DateTime : {dt}");
        });

        Try("GetEnvironmentVariable('TEMP')", () =>
        {
            var envVal = client.ControllerService.GetEnvironmentVariable("TEMP");
            Console.WriteLine($"  TEMP     : {envVal}");
        });

        Console.WriteLine("\nDone.");
    }
}
