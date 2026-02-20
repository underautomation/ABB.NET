using UnderAutomation.ABB.Tests.Rws2;
using static UnderAutomation.ABB.Tests.Rws2.TestHelper;

/// <summary>
/// Test: RapidService — GetExecutionState, GetTasks, GetModules, GetSymbolData
/// </summary>
class TestRapid
{
    public static void Run()
    {
        var client = Connect();
        string? taskName = null;

        Try("GetExecutionState", () =>
        {
            var exec = client.RapidService.GetExecutionState();
            Console.WriteLine($"  State : {exec.State}");
            Console.WriteLine($"  Cycle : {exec.Cycle}");
        });

        Try("GetTasks", () =>
        {
            var tasks = client.RapidService.GetTasks();
            foreach (var t in tasks)
                Console.WriteLine($"  Task: {t.Name}  Type:{t.Type}  Active:{t.Active}  ExecState:{t.ExecutionState}");
            if (tasks.Length > 0) taskName = tasks[0].Name;
        });

        if (taskName != null)
        {
            var tn = taskName;
            Try($"GetModules('{tn}')", () =>
            {
                var modules = client.RapidService.GetModules(tn);
                foreach (var m in modules)
                    Console.WriteLine($"  Module: {m.Name}  Type:{m.Type}");
            });
        }

        Console.WriteLine("\nDone.");
    }
}
