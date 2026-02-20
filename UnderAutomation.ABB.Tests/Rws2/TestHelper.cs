using UnderAutomation.ABB.Rws2;

namespace UnderAutomation.ABB.Tests.Rws2
{
    /// <summary>
    /// Shared helper to create a connected Rws2Client for all test scripts.
    /// Simulation controller available at localhost:80 HTTP with default credentials.
    /// </summary>
    public static class TestHelper
    {
        public const string IP = "localhost";
        public const string Username = "Default User";
        public const string Password = "robotics";
        public const int Port = 80;
        public const bool UseHttps = false;
        public const int Timeout = 10000;

        /// <summary>
        /// Creates and connects a new Rws2Client to the simulation controller.
        /// </summary>
        public static Rws2Client Connect()
        {
            var client = new Rws2Client();
            Console.WriteLine($"Connecting to {IP}:{Port} (HTTPS={UseHttps}) ...");
            client.Connect(IP, Username, Password, Port, Timeout, UseHttps);
            Console.WriteLine("Connected.");
            return client;
        }

        /// <summary>
        /// Runs an action and prints the result. Catches exceptions gracefully.
        /// </summary>
        public static void Try(string label, Action action)
        {
            Console.WriteLine($"\n=== {label} ===");
            try
            {
                action();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
            }
        }
    }
}
