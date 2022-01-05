using System;
using System.Diagnostics;
using System.Reflection;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var assembly = Assembly.GetExecutingAssembly();

            Console.WriteLine($"AssemblyVersion: {assembly.GetName().Version}");

            var versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            Console.WriteLine($"AssemblyFileVersion: {versionInfo.FileVersion}");
            Console.WriteLine($"AssemblyInformationalVersion: {versionInfo.ProductVersion}");
        }
    }
}
