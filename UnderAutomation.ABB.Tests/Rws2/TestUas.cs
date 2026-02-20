using UnderAutomation.ABB.Tests.Rws2;
using static UnderAutomation.ABB.Tests.Rws2.TestHelper;

/// <summary>
/// Test: UasService — GetUsers, GetRoles, GetGrants, GetUserRoles, GetUserGrants
/// </summary>
class TestUas
{
    public static void Run()
    {
        var client = Connect();

        Try("GetUsers", () =>
        {
            var users = client.UasService.GetUsers();
            Console.WriteLine($"  Users count : {users?.Length}");
            if (users != null)
                foreach (var u in users)
                    Console.WriteLine($"  - {u.Name}: {u.Description}");
        });

        Try("GetRoles", () =>
        {
            var roles = client.UasService.GetRoles();
            Console.WriteLine($"  Roles count : {roles?.Length}");
            if (roles != null)
                foreach (var r in roles)
                    Console.WriteLine($"  - {r.RoleName}");
        });

        Try("GetGrants", () =>
        {
            var grants = client.UasService.GetGrants();
            Console.WriteLine($"  Grants count : {grants?.Length}");
            if (grants != null)
                foreach (var g in grants.Take(5))
                    Console.WriteLine($"  - {g.GrantName}: {g.DisplayName}");
        });

        Try("GetUserRoles('Default User')", () =>
        {
            var roles = client.UasService.GetUserRoles("Default User");
            Console.WriteLine($"  Roles : {string.Join(", ", roles ?? Array.Empty<string>())}");
        });

        Try("GetUserGrants('Default User')", () =>
        {
            var grants = client.UasService.GetUserGrants("Default User");
            Console.WriteLine($"  Grants count : {grants?.Length}");
            if (grants != null)
                foreach (var g in grants.Take(5))
                    Console.WriteLine($"  - {g}");
        });

        Console.WriteLine("\nDone.");
    }
}
