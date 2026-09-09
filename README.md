# ABB Robot Communication SDK for .NET

[<img src="https://underautomation.com/abb/abb-communication.svg" alt="UnderAutomation ABB SDK" width="100%">](https://underautomation.com/abb)

[![NuGet](https://img.shields.io/nuget/v/UnderAutomation.ABB?label=NuGet&logo=nuget)](https://www.nuget.org/packages/UnderAutomation.ABB/)
[![NuGet downloads](https://img.shields.io/nuget/dt/UnderAutomation.ABB?label=Downloads&logo=nuget)](https://www.nuget.org/packages/UnderAutomation.ABB/)
[![.NET Framework](https://img.shields.io/badge/.NET_Framework-3.5+-blueviolet)](#compatibility)
[![.NET Standard](https://img.shields.io/badge/.NET_Standard-2.0_2.1-blueviolet)](#compatibility)
[![.NET](https://img.shields.io/badge/.NET-5_to_9-blueviolet)](#compatibility)
[![License](https://img.shields.io/badge/license-commercial-blue)](https://underautomation.com/abb/eula)

**UnderAutomation.ABB** is a fully managed .NET SDK that talks to ABB industrial robot controllers over
**Robot Web Services (RWS)**. It works the same way on **IRC5** (RobotWare 6) and on **OmniCore**
(RobotWare 7). Nothing is installed on the controller. No RobotStudio, no PC SDK, no ABB runtime.

Use it to read and write RAPID variables, control I/O, read positions, jog the robot, manage programs,
files and backups, and follow the state of the controller, from a normal .NET application.

- 📖 **More information:** [underautomation.com/abb](https://underautomation.com/abb)
- 📚 **Documentation:** [underautomation.com/abb/documentation](https://underautomation.com/abb/documentation)
- 📦 **Also available for** [🐍 Python](https://github.com/underautomation/ABB.py) and [🎨 LabVIEW](https://github.com/underautomation/ABB.vi)

---

[⭐ Star this repository if it is useful to you](https://github.com/underautomation/ABB.NET/stargazers) · [👁️ Watch it to follow new releases](https://github.com/underautomation/ABB.NET/watchers)

---

## What you can do

- 🧾 **RAPID variables and programs:** read and write variables, persistents and constants, including
  `robtarget` and record types. Start and stop tasks, move the program pointer, load and save modules,
  search the symbols of the loaded program.
- ⚡ **Inputs / Outputs:** list, read and write digital, analog and group signals. Pulse, invert or
  simulate a signal. Browse and configure I/O devices and networks.
- 📐 **Position and kinematics:** read the current `robtarget` and `jointtarget`, convert between
  Cartesian pose and joint values, jog the robot, set a position target.
- 🎛️ **Controller and state:** read the identity and the options, follow the operation mode, the
  controller state and the speed ratio, set the clock, the language and the network.
- 💾 **Backup and restore:** create a full backup, check it, and restore it.
- 📂 **File system:** browse the controller file system, download and upload files, create, copy, rename
  and delete files and directories.
- 📜 **Event log:** read the event log by domain, in the language you ask, and clear it.
- 🔋 **System and energy:** read the system product list, the options and the energy counters.
- 🔑 **Mastership:** request and release the edit and motion mastership, explicitly or implicitly.
- 🔁 **One API for both controller generations:** the same code runs on IRC5 (RWS 1.0) and on OmniCore
  (RWS 2.0). Only one connection parameter changes.
- ⏱️ **Sync and async:** every service method has a synchronous version and, from .NET Framework 4.5 on,
  an `...Async` version that takes a `CancellationToken`.

No ABB option is required on the controller. Robot Web Services is part of a standard system.

---

## Example application

A Windows Forms application shows every feature of the SDK, with the source code included in this
repository under [`UnderAutomation.ABB.Showcase.Forms`](UnderAutomation.ABB.Showcase.Forms).

📥 **Download:** [UnderAutomation.Abb.Showcase.Forms.exe](https://github.com/underautomation/ABB.NET/releases/latest/download/UnderAutomation.Abb.Showcase.Forms.exe) · [All releases](https://github.com/underautomation/ABB.NET/releases)

**Controller, backup and state**

![Controller demo](https://underautomation.com/abb/WinformsScreenshots/Rws.jpg)

**RAPID variables and programs**

![RAPID demo](https://underautomation.com/abb/WinformsScreenshots/RwsRapid.jpg)

**Inputs / Outputs**

![I/O demo](https://underautomation.com/abb/WinformsScreenshots/RwsIo.jpg)

**Position and kinematics**

![Motion system demo](https://underautomation.com/abb/WinformsScreenshots/RwsMotionSystem.jpg)

---

## Installation

```bash
dotnet add package UnderAutomation.ABB
```

Or with the NuGet Package Manager console:

```
Install-Package UnderAutomation.ABB
```

You can also download the DLL from the [releases page](https://github.com/underautomation/ABB.NET/releases)
and reference it by hand.

---

## Getting started

### 1. Connect

```csharp
using UnderAutomation.ABB;

// The SDK runs in trial mode for 30 days. Register your key to remove the trial limit.
AbbController.RegisterLicense("Your Company", "your-license-key");

var robot = new AbbController();
robot.Connect("192.168.125.1");

var identity = robot.Rws.Controller.GetIdentity();
Console.WriteLine(identity.Name);

robot.Disconnect();
```

### 2. Choose the controller generation

The default is OmniCore (RWS 2.0). For an IRC5 controller, set the version to `RwsVersion.Irc5_V1_0`.
The rest of your code does not change.

```csharp
var parameters = new ConnectionParameters("192.168.125.1");
parameters.Rws.Username = "Default User";
parameters.Rws.Password = "robotics";
parameters.Rws.UseHttps = true;                    // OmniCore is reached over HTTPS
parameters.Rws.Version  = RwsVersion.OmniCore_V2_0; // or RwsVersion.Irc5_V1_0 for IRC5

var robot = new AbbController();
robot.Connect(parameters);
```

---

## Features

Everything is reached through `robot.Rws`, grouped by service:
`Controller`, `Io`, `Rapid`, `MotionSystem`, `Panel`, `System`, `File`, `Elog`, `Mastership`.

### 🧾 RAPID variables and programs

```csharp
// Read a RAPID symbol, the value comes back the way RAPID writes it
var reg1 = robot.Rws.Rapid.GetSymbolValue("RAPID/T_ROB1/user/reg1");
Console.WriteLine(reg1.Value);

// Write a symbol (needs the edit mastership in automatic mode)
robot.Rws.Mastership.Request(MastershipDomain.Edit);
robot.Rws.Rapid.SetSymbolValue("RAPID/T_ROB1/user/reg1", "42");
robot.Rws.Mastership.Release();

// Start and stop the program
robot.Rws.Rapid.Start();
robot.Rws.Rapid.Stop();

// Load a module, list tasks, follow the execution state
robot.Rws.Rapid.LoadModule("T_ROB1", "HOME:/mymodule.mod", replace: true);
var tasks = robot.Rws.Rapid.GetTasks();
var state = robot.Rws.Rapid.GetExecutionState();
```

### ⚡ Inputs / Outputs

```csharp
// List every signal
IoSignalItem[] signals = robot.Rws.Io.GetSignals();

// Read one signal
IoSignalItem di1 = robot.Rws.Io.GetSignal("EtherNetIP", "d652", "DI_01");
Console.WriteLine(di1.LogicalValue);

// Write, pulse or invert an output
robot.Rws.Io.SetSignalValue("EtherNetIP", "d652", "DO_01", 1);
robot.Rws.Io.PulseSignal("EtherNetIP", "d652", "DO_01", 1, pulses: 3);
robot.Rws.Io.InvertSignal("EtherNetIP", "d652", "DO_01", 1);

// Simulate a signal so a value can be forced without hardware
robot.Rws.Io.SetSignalState("EtherNetIP", "d652", "DI_01", simulated: true);
```

### 📐 Position and kinematics

```csharp
// Current Cartesian and joint position of a mechanical unit
RobTarget robTarget = robot.Rws.MotionSystem.GetRobTarget("ROB_1");
JointTarget jointTarget = robot.Rws.MotionSystem.GetJointTarget("ROB_1");

Console.WriteLine($"X={robTarget.X} Y={robTarget.Y} Z={robTarget.Z}");
Console.WriteLine($"J1={jointTarget.RobotAxes.Axis1} J2={jointTarget.RobotAxes.Axis2}");

// Convert a Cartesian pose to joint values
JointTarget joints = robot.Rws.MotionSystem.GetJointsFromCartesian("ROB_1", pose, externalAxes);

// Jog the robot
robot.Rws.MotionSystem.SetJoggingMechanicalUnit("ROB_1");
robot.Rws.MotionSystem.Jog(new RobotJoints { Axis1 = 5 }, changeCount: 0);
```

### 🎛️ Controller and state

```csharp
ControllerIdentity id = robot.Rws.Controller.GetIdentity();
ControllerInfo info = robot.Rws.Controller.GetInfo();

OperationMode mode = robot.Rws.Panel.GetOperationMode();
ControllerState state = robot.Rws.Panel.GetControllerState();
int speedRatio = robot.Rws.Panel.GetSpeedRatio();

robot.Rws.Panel.SetSpeedRatio(50);
robot.Rws.Controller.SetClock(DateTime.Now);

bool hasOption = robot.Rws.Controller.HasOption("RobotWare-OS");
```

### 💾 Backup and restore

```csharp
robot.Rws.Controller.CreateBackup("HOME:/backups/2026-01-15");

CheckRestoreResult check = robot.Rws.Controller.CheckRestore("HOME:/backups/2026-01-15");
if (check.IsAccepted)
    robot.Rws.Controller.RestoreBackup("HOME:/backups/2026-01-15");
```

### 📂 File system

```csharp
DirectoryListing listing = robot.Rws.File.ListDirectory("HOME:/");
foreach (var dir in listing.Directories)
    Console.WriteLine(dir.Name);
foreach (var file in listing.Files)
    Console.WriteLine($"{file.Name} ({file.Size} bytes)");

robot.Rws.File.UploadFileFromPath("HOME:/mymodule.mod", @"C:\rapid\mymodule.mod");
robot.Rws.File.GetFileToDestination("HOME:/mymodule.mod", @"C:\backup\mymodule.mod");
string text = robot.Rws.File.GetFileAsText("HOME:/mymodule.mod");
robot.Rws.File.DeleteFile("HOME:/old.mod");
```

### 📜 Event log

```csharp
ElogMessage[] messages = robot.Rws.Elog.GetMessages(domain: 0, language: "en");
foreach (var m in messages)
    Console.WriteLine($"{m.Timestamp} {m.Title}");

robot.Rws.Elog.ClearAllMessages();
```

### ⏱️ Asynchronous methods

Every method has an async version on .NET Framework 4.5 and later.

```csharp
var identity = await robot.Rws.Controller.GetIdentityAsync(cancellationToken);
await robot.Rws.Io.SetSignalValueAsync("EtherNetIP", "d652", "DO_01", 1, cancellationToken);
```

---

## IRC5 and OmniCore, one API

ABB robots expose Robot Web Services in two versions. This SDK covers both. The same code runs on an
old IRC5 and on a new OmniCore. Only the connection parameters change.

| Controller | RobotWare | Robot Web Services | `RwsVersion` value |
|---|---|---|---|
| IRC5 | RobotWare 6 and earlier | RWS 1.0 | `RwsVersion.Irc5_V1_0` |
| OmniCore | RobotWare 7 and later | RWS 2.0 | `RwsVersion.OmniCore_V2_0` |

HTTP or HTTPS is a separate setting (`UseHttps`), independent of the controller generation.

---

## Compatibility

| Target Framework | Supported | Async methods |
|---|---|---|
| .NET 9.0 / 8.0 / 6.0 / 5.0 | ✅ | ✅ |
| .NET Core 3.0 | ✅ | ✅ |
| .NET Standard 2.1 / 2.0 | ✅ | ✅ |
| .NET Framework 4.5 to 4.8 | ✅ | ✅ |
| .NET Framework 3.5 / 4.0 | ✅ | ❌ (sync only) |

- **Operating systems:** Windows, Linux, macOS
- **No native dependency**, no external NuGet package
- **Supported controllers:** IRC5, OmniCore, and their virtual controllers in RobotStudio

---

## License

This SDK requires a commercial license. A 30-day free trial is available, no key needed.

- 🔑 **Trial and licensing:** [underautomation.com/abb/eula](https://underautomation.com/abb/eula)
- 🛒 **Request a quote and order:** [underautomation.com/abb](https://underautomation.com/abb)

See [License.md](License.md) for the full terms.

---

## Support

- 📚 **Documentation:** [underautomation.com/abb/documentation](https://underautomation.com/abb/documentation)
- 🐛 **Issues:** [GitHub Issues](https://github.com/underautomation/ABB.NET/issues)
- 📩 **Contact:** [underautomation.com/contact](https://underautomation.com/contact)
