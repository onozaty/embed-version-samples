using System.Diagnostics;
using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();

Console.WriteLine($"Version: {assembly.GetName().Version}");

var versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

Console.WriteLine($"FileVersion: {versionInfo.FileVersion}");
Console.WriteLine($"ProductVersion: {versionInfo.ProductVersion}");
