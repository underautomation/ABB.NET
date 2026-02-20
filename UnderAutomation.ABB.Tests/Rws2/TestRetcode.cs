using UnderAutomation.ABB.Tests.Rws2;
using static UnderAutomation.ABB.Tests.Rws2.TestHelper;

/// <summary>
/// Test: RetcodeService — GetReturnCodes
/// </summary>
class TestRetcode
{
    public static void Run()
    {
        var client = Connect();

        Try("GetReturnCodes (all)", () =>
        {
            var codes = client.RetcodeService.GetReturnCodes();
            Console.WriteLine($"  Return codes count : {codes?.Length}");
            if (codes != null)
                foreach (var c in codes.Take(5))
                    Console.WriteLine($"  - {c.Code}: {c.Name} ({c.Severity})");
        });

        Try("GetReturnCodes (specific code)", () =>
        {
            var codes = client.RetcodeService.GetReturnCodes();
            if (codes != null && codes.Length > 0)
            {
                var first = codes[0];
                var result = client.RetcodeService.GetReturnCodes(first.Code);
                Console.WriteLine($"  Searched for code: {first.Code}");
                Console.WriteLine($"  Results: {result?.Length}");
            }
        });

        Console.WriteLine("\nDone.");
    }
}
