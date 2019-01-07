﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Splat
{
    /// <summary>
    /// Extension methods that help to get the target framework for a assembly.
    /// </summary>
    public static class TargetFrameworkExtensions
    {
        /// <summary>
        /// Gets the target framework for an assembly.
        /// </summary>
        /// <param name="assembly">The assembly to get the target framework for.</param>
        /// <returns>The target framework or null if not known.</returns>
        public static string GetTargetFrameworkName(this Assembly assembly)
        {
            var targetFrameworkAttribute = assembly.GetCustomAttribute<TargetFrameworkAttribute>();

            switch (targetFrameworkAttribute.FrameworkName)
            {
                case ".NETCoreApp,Version=v2.2":
                    return "netcoreapp2.2";
                case ".NETCoreApp,Version=v2.1":
                    return "netcoreapp2.1";
                case ".NETCoreApp,Version=v2.0":
                    return "netcoreapp2.0";
                case ".NETCoreApp,Version=v1.1":
                    return "netcoreapp1.1";
                case ".NETCoreApp,Version=v1.0":
                    return "netcoreapp1.0";

                case ".NETStandard,Version=v2.0":
                    return "netstandard2.0";
                case ".NETStandard,Version=v1.6":
                    return "netstandard1.6";
                case ".NETStandard,Version=v1.5":
                    return "netstandard1.5";
                case ".NETStandard,Version=v1.4":
                    return "netstandard1.4";
                case ".NETStandard,Version=v1.3":
                    return "netstandard1.3";
                case ".NETStandard,Version=v1.2":
                    return "netstandard1.2";
                case ".NETStandard,Version=v1.1":
                    return "netstandard1.1";
                case ".NETStandard,Version=v1.0":
                    return "netstandard1.0";

                case ".NETFramework,Version=v4.7.2":
                    return "net472";
                case ".NETFramework,Version=v4.7.1":
                    return "net471";
                case ".NETFramework,Version=v4.7":
                    return "net47";
                case ".NETFramework,Version=v4.6.2":
                    return "net462";
                case ".NETFramework,Version=v4.6.1":
                    return "net461";
                case ".NETFramework,Version=v4.6":
                    return "net46";
                case ".NETFramework,Version=v4.5.2":
                    return "net452";
                case ".NETFramework,Version=v4.5.1":
                    return "net451";
                case ".NETFramework,Version=v4.5":
                    return "net45";
                case ".NETFramework,Version=v4.0.3":
                    return "net403";
                case ".NETFramework,Version=v4.0":
                    return "net40";
                case ".NETFramework,Version=v3.5":
                    return "net35";
                case ".NETFramework,Version=v2.0":
                    return "net20";
                case ".NETFramework,Version=v1.1":
                    return "net11";
            }

            return null;
        }
    }
}