using UnderAutomation.ABB.Tests.Rws2;
using static UnderAutomation.ABB.Tests.Rws2.TestHelper;

/// <summary>
/// Test: SystemService — GetSystemInfo, GetOptions, GetRobotType, GetLicense, GetEnergy
/// </summary>
class TestSystem
{
    public static void Run()
    {
        var client = Connect();

        Try("GetSystemInfo", () =>
        {
            var info = client.SystemService.GetSystemInfo();
            Console.WriteLine($"  Name       : {info.Name}");
            Console.WriteLine($"  SystemId   : {info.SystemId}");
            Console.WriteLine($"  RwVersion  : {info.RwVersion}");
            Console.WriteLine($"  Title      : {info.Title}");
        });

        Try("GetOptions", () =>
        {
            var options = client.SystemService.GetOptions();
            Console.WriteLine($"  Options count : {options?.Length}");
            if (options != null)
                foreach (var opt in options.Take(5))
                    Console.WriteLine($"  - {opt}");
        });

        Try("GetRobotType", () =>
        {
            var type = client.SystemService.GetRobotType();
            Console.WriteLine($"  RobotType : {type}");
        });

        Try("GetLicense", () =>
        {
            var lic = client.SystemService.GetLicense();
            Console.WriteLine($"  License : {lic}");
        });

        Try("GetEnergy", () =>
        {
            var energy = client.SystemService.GetEnergy();
            Console.WriteLine($"  State    : {energy.State}");
            Console.WriteLine($"  Interval : {energy.IntervalEnergy}");
            Console.WriteLine($"  Accum    : {energy.AccumulatedEnergy}");
        });

        Console.WriteLine("\nDone.");
    }
}
