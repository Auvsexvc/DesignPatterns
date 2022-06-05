using System;
using System.Collections.Generic;

namespace Facade
{
    public class SecurityScanner
    {
        public IEnumerable<string> SecurityScan(string githubUrl)
        {
            Console.WriteLine("Security scan");

            return new List<string>() { "security error1" };
        }
    }
}