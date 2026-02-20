using UnderAutomation.ABB.Tests.Rws2;
using static UnderAutomation.ABB.Tests.Rws2.TestHelper;

/// <summary>
/// Test: MotionSystemService — GetMechUnits, GetMechUnit, GetCartesian, GetRobTarget, GetJointTarget
/// </summary>
class TestMotion
{
    public static void Run()
    {
        var client = Connect();

        Try("GetMechUnits", () =>
        {
            var units = client.MotionSystemService.GetMechUnits();
            Console.WriteLine($"  Units count : {units?.Length}");
            if (units != null)
                foreach (var u in units)
                    Console.WriteLine($"  - {u.Name} (mode: {u.Mode})");
        });

        Try("GetMechUnit('ROB_1')", () =>
        {
            var detail = client.MotionSystemService.GetMechUnit("ROB_1");
            Console.WriteLine($"  Tool   : {detail.ToolName}");
            Console.WriteLine($"  WObj   : {detail.WobjName}");
            Console.WriteLine($"  Axes   : {detail.Axes}");
            Console.WriteLine($"  Status : {detail.Status}");
        });

        Try("GetCartesian('ROB_1')", () =>
        {
            var pos = client.MotionSystemService.GetCartesian("ROB_1");
            Console.WriteLine($"  X={pos.X}  Y={pos.Y}  Z={pos.Z}");
            Console.WriteLine($"  Q1={pos.Q1}  Q2={pos.Q2}  Q3={pos.Q3}  Q4={pos.Q4}");
        });

        Try("GetRobTarget('ROB_1')", () =>
        {
            var target = client.MotionSystemService.GetRobTarget("ROB_1");
            Console.WriteLine($"  X={target.X}  Y={target.Y}  Z={target.Z}");
            Console.WriteLine($"  Q1={target.Q1}  Q2={target.Q2}  Q3={target.Q3}  Q4={target.Q4}");
        });

        Try("GetJointTarget('ROB_1')", () =>
        {
            var jt = client.MotionSystemService.GetJointTarget("ROB_1");
            Console.WriteLine($"  Rax1={jt.Rax1}  Rax2={jt.Rax2}  Rax3={jt.Rax3}");
            Console.WriteLine($"  Rax4={jt.Rax4}  Rax5={jt.Rax5}  Rax6={jt.Rax6}");
        });

        Console.WriteLine("\nDone.");
    }
}
