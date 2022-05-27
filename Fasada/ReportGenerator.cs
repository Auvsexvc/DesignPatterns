using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    public class ReportGenerator
    {
        public void GenerateReport(IEnumerable<string> qualityScanErrors, IEnumerable<string> securityScanErrors, IEnumerable<string> dependencyScanErrors)
        {
            Console.WriteLine("Quality scan errors:");
            Console.WriteLine(string.Join(", ", qualityScanErrors));
            Console.WriteLine("Security scan errors:");
            Console.WriteLine(string.Join(", ", securityScanErrors));
            Console.WriteLine("Dependency scan errors:");
            Console.WriteLine(string.Join(", ", dependencyScanErrors));
        }
    }
}
