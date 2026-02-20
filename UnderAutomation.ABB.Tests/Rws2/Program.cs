using UnderAutomation.ABB.Tests.Rws2;

/// <summary>
/// Dispatcher: run all tests or a specific one via command-line argument.
/// Usage: dotnet run [controller|panel|io|rapid|file|subscription|system|mastership|elog|cfg|motion|dipc|uas|retcode]
/// Without argument, runs all tests sequentially.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        var test = args.Length > 0 ? args[0].ToLowerInvariant() : "all";

        if (test == "all" || test == "controller") TestController.Run();
        if (test == "all" || test == "panel") TestPanel.Run();
        if (test == "all" || test == "io") TestIO.Run();
        if (test == "all" || test == "rapid") TestRapid.Run();
        if (test == "all" || test == "file") TestFile.Run();
        if (test == "all" || test == "subscription") TestSubscription.Run();
        if (test == "all" || test == "system") TestSystem.Run();
        if (test == "all" || test == "mastership") TestMastership.Run();
        if (test == "all" || test == "elog") TestElog.Run();
        if (test == "all" || test == "cfg") TestCfg.Run();
        if (test == "all" || test == "motion") TestMotion.Run();
        if (test == "all" || test == "dipc") TestDipc.Run();
        if (test == "all" || test == "uas") TestUas.Run();
        if (test == "all" || test == "retcode") TestRetcode.Run();
    }
}
