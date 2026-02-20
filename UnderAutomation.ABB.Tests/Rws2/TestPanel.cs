using UnderAutomation.ABB.Tests.Rws2;
using static UnderAutomation.ABB.Tests.Rws2.TestHelper;

/// <summary>
/// Test: PanelService — GetOperationMode, GetControllerState, GetSpeedRatio, SetSpeedRatio
/// </summary>
class TestPanel
{
    public static void Run()
    {
        var client = Connect();

        Try("GetOperationMode", () =>
        {
            var mode = client.PanelService.GetOperationMode();
            Console.WriteLine($"  Mode : {mode}");
        });

        Try("GetControllerState", () =>
        {
            var state = client.PanelService.GetControllerState();
            Console.WriteLine($"  State : {state}");
        });

        Try("GetSpeedRatio", () =>
        {
            var speed = client.PanelService.GetSpeedRatio();
            Console.WriteLine($"  Speed : {speed}%");
        });

        Try("SetSpeedRatio(50)", () =>
        {
            client.PanelService.SetSpeedRatio(50);
            Console.WriteLine("  OK");
            var newSpeed = client.PanelService.GetSpeedRatio();
            Console.WriteLine($"  Verified speed : {newSpeed}%");
        });

        Console.WriteLine("\nDone.");
    }
}
