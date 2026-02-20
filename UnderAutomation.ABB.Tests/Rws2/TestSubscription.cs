using UnderAutomation.ABB.Rws2;
using UnderAutomation.ABB.Tests.Rws2;
using static UnderAutomation.ABB.Tests.Rws2.TestHelper;

/// <summary>
/// Test: SubscriptionService — Subscribe, Unsubscribe
/// </summary>
class TestSubscription
{
    public static void Run()
    {
        var client = Connect();
        string? groupId = null;

        Try("Subscribe to /rw/panel/speedratio", () =>
        {
            var resource = new SubscriptionResource("/rw/panel/speedratio", SubscriptionPriority.Medium);
            var group = client.SubscriptionService.Subscribe(resource);
            Console.WriteLine($"  GroupId       : {group.GroupId}");
            Console.WriteLine($"  WebSocketUrl  : {group.WebSocketUrl}");
            groupId = group.GroupId;
        });

        if (groupId != null)
        {
            var gid = groupId;
            Try("Unsubscribe", () =>
            {
                client.SubscriptionService.Unsubscribe(gid);
                Console.WriteLine("  OK");
            });
        }

        Console.WriteLine("\nDone.");
    }
}
