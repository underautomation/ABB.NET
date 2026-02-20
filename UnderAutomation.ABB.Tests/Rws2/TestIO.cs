using UnderAutomation.ABB.Tests.Rws2;
using static UnderAutomation.ABB.Tests.Rws2.TestHelper;

/// <summary>
/// Test: IOService — GetNetworks, GetSignals, GetSignal
/// </summary>
class TestIO
{
    public static void Run()
    {
        var client = Connect();

        UnderAutomation.ABB.Rws2.Data.IOSignal[]? signals = null;

        Try("GetNetworks", () =>
        {
            var networks = client.IOService.GetNetworks();
            foreach (var n in networks)
                Console.WriteLine($"  Network: {n.Name}  Type: {n.Type}  State: {n.State}");
        });

        Try("GetSignals (first 10)", () =>
        {
            signals = client.IOService.GetSignals();
            var count = 0;
            foreach (var s in signals)
            {
                Console.WriteLine($"  {s.Network}/{s.Device}/{s.Name}  Type:{s.Type}  Value:{s.Value}");
                if (++count >= 10) { Console.WriteLine("  ..."); break; }
            }
            Console.WriteLine($"  Total signals: {signals.Length}");
        });

        if (signals != null && signals.Length > 0)
        {
            var first = signals[0];
            Try($"GetSignal({first.Network}, {first.Device}, {first.Name})", () =>
            {
                var sig = client.IOService.GetSignal(first.Network, first.Device, first.Name);
                Console.WriteLine($"  Name:{sig.Name}  Value:{sig.Value}  Type:{sig.Type}");
            });
        }

        Console.WriteLine("\nDone.");
    }
}
