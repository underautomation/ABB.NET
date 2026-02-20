using UnderAutomation.ABB.Tests.Rws2;
using static UnderAutomation.ABB.Tests.Rws2.TestHelper;

/// <summary>
/// Test: MastershipService — GetEditDomain, GetMotionDomain, RequestAll, ReleaseAll
/// </summary>
class TestMastership
{
    public static void Run()
    {
        var client = Connect();

        Try("GetEditDomain", () =>
        {
            var domain = client.MastershipService.GetEditDomain();
            Console.WriteLine($"  Alias      : {domain.Alias}");
            Console.WriteLine($"  Mastership : {domain.Mastership}");
            Console.WriteLine($"  HeldByMe   : {domain.MastershipHeldByMe}");
        });

        Try("GetMotionDomain", () =>
        {
            var domain = client.MastershipService.GetMotionDomain();
            Console.WriteLine($"  Alias      : {domain.Alias}");
            Console.WriteLine($"  Mastership : {domain.Mastership}");
            Console.WriteLine($"  HeldByMe   : {domain.MastershipHeldByMe}");
        });

        Try("RequestAll + ReleaseAll", () =>
        {
            client.MastershipService.RequestAll();
            Console.WriteLine("  RequestAll OK");
            client.MastershipService.ReleaseAll();
            Console.WriteLine("  ReleaseAll OK");
        });

        Try("Request('edit') + Release('edit')", () =>
        {
            client.MastershipService.Request("edit");
            Console.WriteLine("  Request edit OK");
            client.MastershipService.Release("edit");
            Console.WriteLine("  Release edit OK");
        });

        Console.WriteLine("\nDone.");
    }
}
