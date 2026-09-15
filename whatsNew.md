## Discover ABB controllers on the network

`AbbController.Discover` and `AbbController.DiscoverAsync` look for ABB controllers without opening a
connection and without a license. Two ways run together: listening for the announcements a controller
sends on the network, and testing the ports of the local machine, which finds a virtual controller of
RobotStudio whatever port it was given.

Each result is a `DiscoveredController`, with the address, the port, the RobotWare version when known,
and a `ToConnectionParameters` method that builds parameters ready for `Connect`.

```csharp
DiscoveredController[] found = AbbController.Discover();

foreach (var controller in found)
    Console.WriteLine($"{controller.SystemName} at {controller.Address}:{controller.Port}");

AbbController robot = new AbbController();
robot.Connect(found[0].ToConnectionParameters());
```

## Breaking change: removed `RwsConnectParametersBase.Ip`

This property had no effect, the controller address was always taken from `ConnectionParameters.Address`.
Remove any code that sets `parameters.Rws.Ip`, it was never read.
