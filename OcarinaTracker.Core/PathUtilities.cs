using System;
using System.IO;
using System.Reflection;

namespace OcarinaTracker.Core
{
    public static class PathUtilities
    {
        public static string GetDirectoryPath(this Assembly assembly) =>
            Path.GetDirectoryName(new Uri(assembly.CodeBase).LocalPath);
    }
}
