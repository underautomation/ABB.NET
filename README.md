# UnderAutomation ABB .NET SDK

[![NuGet](https://img.shields.io/nuget/v/UnderAutomation.ABB)](https://www.nuget.org/packages/UnderAutomation.ABB/)
[![License](https://img.shields.io/badge/license-commercial-blue)](https://underautomation.com/license)

Fully-managed .NET library to communicate with **ABB industrial robot controllers** (IRC5, IRC6). No native dependencies, no ABB SDK required.

## Installation

```bash
dotnet add package UnderAutomation.ABB
```

Or via NuGet Package Manager:
```
Install-Package UnderAutomation.ABB
```

## Quick Start

```csharp
using UnderAutomation.ABB;

// Optional: register your license (runs in trial mode for 30 days without key)
AbbController.RegisterLicense("Your Organization", "your-license-key");

// Connect to the robot controller
var robot = new AbbController();
robot.Connect("192.168.0.1");

// Disconnect when done
robot.Disconnect();
```

## License

This is a commercial library. A 30-day free trial is available at [underautomation.com/license](https://underautomation.com/license).

Purchase a lifetime license at [underautomation.com/order](https://underautomation.com/order).

## Compatibility

| Target Framework | Supported |
|---|---|
| .NET 9.0 | ✅ |
| .NET 8.0 | ✅ |
| .NET 6.0 | ✅ |
| .NET 5.0 | ✅ |
| .NET Core 3.0 | ✅ |
| .NET Standard 2.1 | ✅ |
| .NET Standard 2.0 | ✅ |
| .NET Framework 4.8 | ✅ |
| .NET Framework 4.x | ✅ |
| .NET Framework 3.5 | ✅ |
