using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Embed Version Sample")]
[assembly: AssemblyDescription("Embed Version Sample Description")]
[assembly: ComVisible(false)]
[assembly: AssemblyProduct("Embed Version Sample")]
[assembly: AssemblyCopyright("Copyright © 2021")]
// https://github.com/devlooped/GitInfo
[assembly: AssemblyVersion(ThisAssembly.Git.BaseVersion.Major + "." + ThisAssembly.Git.BaseVersion.Minor + "." + ThisAssembly.Git.BaseVersion.Patch)]
[assembly: AssemblyFileVersion(ThisAssembly.Git.BaseVersion.Major + "." + ThisAssembly.Git.BaseVersion.Minor + "." + ThisAssembly.Git.BaseVersion.Patch)]
[assembly: AssemblyInformationalVersion(ThisAssembly.Git.BaseVersion.Major + "." + ThisAssembly.Git.BaseVersion.Minor + "." + ThisAssembly.Git.BaseVersion.Patch + ThisAssembly.Git.SemVer.DashLabel + "." + ThisAssembly.Git.Commit)]
[assembly: Guid("ec86a331-8ca3-4979-a09b-e96995eac5b9")]
