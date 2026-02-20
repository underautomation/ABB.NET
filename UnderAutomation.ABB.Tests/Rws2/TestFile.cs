using UnderAutomation.ABB.Tests.Rws2;
using static UnderAutomation.ABB.Tests.Rws2.TestHelper;

/// <summary>
/// Test: FileService — GetDevices, GetDirectoryContents, GetFileContent
/// </summary>
class TestFile
{
    public static void Run()
    {
        var client = Connect();

        Try("GetDevices", () =>
        {
            var devices = client.FileService.GetDevices();
            foreach (var d in devices)
                Console.WriteLine($"  Device: {d.Name}  Type:{d.DeviceType}  Total:{d.TotalSpace}  Free:{d.FreeSpace}");
        });

        Try("GetDirectoryContents('$home')", () =>
        {
            var entries = client.FileService.GetDirectoryContents("$home");
            foreach (var e in entries)
                Console.WriteLine($"  {(e.IsDirectory ? "[DIR]" : "[FILE]")} {e.Name}  Size:{e.Size}  Modified:{e.ModificationDate}");
        });

        Console.WriteLine("\nDone.");
    }
}
