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

            Console.WriteLine($"Version: {assembly.GetName().Version}");

            var versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            Console.WriteLine($"FileVersion: {versionInfo.FileVersion}");
            Console.WriteLine($"ProductVersion: {versionInfo.ProductVersion}");
        }
    }
}
