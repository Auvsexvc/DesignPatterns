using System;
using System.Collections.Generic;

namespace Facade
{
    public class DependencyScanner
    {
        public IEnumerable<string> DependencyScan(string githubUrl)
        {
            Console.WriteLine("Dependency scan");

            return new List<string>() { "Dependency error" };
        }
    }
}