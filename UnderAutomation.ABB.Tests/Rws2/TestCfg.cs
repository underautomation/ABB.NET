using UnderAutomation.ABB.Tests.Rws2;
using static UnderAutomation.ABB.Tests.Rws2.TestHelper;

/// <summary>
/// Test: CfgService — GetDomains, GetTypes, GetInstances, GetAttributes
/// </summary>
class TestCfg
{
    public static void Run()
    {
        var client = Connect();

        Try("GetDomains", () =>
        {
            var domains = client.CfgService.GetDomains();
            Console.WriteLine($"  Domains count : {domains?.Length}");
            if (domains != null)
                foreach (var d in domains)
                    Console.WriteLine($"  - {d}");
        });

        Try("GetTypes('MOC')", () =>
        {
            var types = client.CfgService.GetTypes("MOC");
            Console.WriteLine($"  Types count : {types?.Length}");
            if (types != null)
                foreach (var t in types.Take(5))
                    Console.WriteLine($"  - {t}");
        });

        Try("GetAttributes('MOC', first type)", () =>
        {
            var types = client.CfgService.GetTypes("MOC");
            if (types != null && types.Length > 0)
            {
                var attrs = client.CfgService.GetAttributes("MOC", types[0]);
                Console.WriteLine($"  Attributes for {types[0]}: {attrs?.Length}");
                if (attrs != null)
                    foreach (var a in attrs.Take(5))
                        Console.WriteLine($"  - {a.Name} ({a.Type})");
            }
        });

        Try("GetInstances('MOC', first type)", () =>
        {
            var types = client.CfgService.GetTypes("MOC");
            if (types != null && types.Length > 0)
            {
                var instances = client.CfgService.GetInstances("MOC", types[0]);
                Console.WriteLine($"  Instances for {types[0]}: {instances?.Length}");
                if (instances != null)
                    foreach (var i in instances.Take(3))
                        Console.WriteLine($"  - {i.InstanceId}");
            }
        });

        Console.WriteLine("\nDone.");
    }
}
