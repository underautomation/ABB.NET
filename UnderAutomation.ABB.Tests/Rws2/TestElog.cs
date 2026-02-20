using UnderAutomation.ABB.Tests.Rws2;
using static UnderAutomation.ABB.Tests.Rws2.TestHelper;

/// <summary>
/// Test: ElogService — GetDomains, GetMessages, ClearAll
/// </summary>
class TestElog
{
    public static void Run()
    {
        var client = Connect();

        Try("GetDomains", () =>
        {
            var domains = client.ElogService.GetDomains();
            Console.WriteLine($"  Domains count : {domains?.Length}");
            if (domains != null)
                foreach (var d in domains)
                    Console.WriteLine($"  - {d.DomainName} (events: {d.NumberOfEvents})");
        });

        Try("GetMessages(domain='0')", () =>
        {
            var messages = client.ElogService.GetMessages("0");
            Console.WriteLine($"  Messages count : {messages?.Length}");
            if (messages != null)
                foreach (var m in messages.Take(3))
                    Console.WriteLine($"  - [{m.MessageType}] {m.Code}: {m.Title}");
        });

        Console.WriteLine("\nDone.");
    }
}
