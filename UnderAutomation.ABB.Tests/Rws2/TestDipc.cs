using UnderAutomation.ABB.Tests.Rws2;
using static UnderAutomation.ABB.Tests.Rws2.TestHelper;

/// <summary>
/// Test: DIPCService — GetQueues, CreateQueue, GetQueueInfo, DeleteQueue
/// </summary>
class TestDipc
{
    public static void Run()
    {
        var client = Connect();

        Try("GetQueues", () =>
        {
            var queues = client.DIPCService.GetQueues();
            Console.WriteLine($"  Queues count : {queues?.Length}");
            if (queues != null)
                foreach (var q in queues)
                    Console.WriteLine($"  - {q}");
        });

        Try("CreateQueue + GetQueueInfo + DeleteQueue", () =>
        {
            var name = "TestQueue_" + DateTime.Now.Ticks;
            client.DIPCService.CreateQueue(name, "5", "444");
            Console.WriteLine($"  Created: {name}");

            var info = client.DIPCService.GetQueueInfo(name);
            Console.WriteLine($"  QueueName: {info.QueueName}");
            Console.WriteLine($"  QueueSize: {info.QueueSize}");
            Console.WriteLine($"  MaxMsgSize: {info.QueueMaxSize}");

            client.DIPCService.DeleteQueue(name);
            Console.WriteLine($"  Deleted: {name}");
        });

        Console.WriteLine("\nDone.");
    }
}
