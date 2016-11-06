using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Prft.Talent.Framework.Extensions
{
    public static class AppDomainExtensions
    {
        /// <summary>
        /// Returns assemblies that are located in private the assembly folder for the <see cref="AppDomain"/> (e.g. .\bin)
        /// </summary>
        /// <param name="source">The <see cref="AppDomain"/> to search</param>
        /// <param name="filePredicate">Filter applied based on file names (executes before attempting to load the assembly)</param>
        /// <param name="assemblyPredicate">Filter applied based on the <see cref="Assembly"/> (executes after assembly is loaded)</param>
        /// <returns></returns>
        public static IEnumerable<Assembly> GetPrivateAssemblies(this AppDomain source, Func<string, bool> filePredicate = null, Func<Assembly, bool> assemblyPredicate = null)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            filePredicate = filePredicate ?? (_ => true);
            assemblyPredicate = assemblyPredicate ?? (_ => true);

            var privateBinFolder = source.RelativeSearchPath ?? source.BaseDirectory;

            return Directory.GetFiles(privateBinFolder, "*.dll")
                .Where(f => filePredicate(Path.GetFileName(f)))
                .Select(Assembly.LoadFrom)
                .Where(assemblyPredicate);
        }

        /// <summary>
        /// Returns assemblies that are located in the private assembly folder for <see cref="AppDomain"/> that begin with <see cref="Prft"/>
        /// </summary>
        /// <param name="source">The <see cref="AppDomain"/> to search</param>
        /// <returns></returns>
        public static IEnumerable<Assembly> GetPrftPrivateAssemblies(this AppDomain source)
        {
            return source.GetPrivateAssemblies(filePredicate: f => f.StartsWith(nameof(Prft), StringComparison.OrdinalIgnoreCase));
        }
    }
}
