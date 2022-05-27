﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    public class ScanFacade
    {
        private QualityScanner qualityScanner = new QualityScanner();
        private SecurityScanner securityScanner = new SecurityScanner();
        private DependencyScanner dependencyScanner = new DependencyScanner();
        private ReportGenerator reportGenerator = new ReportGenerator();
        public void Scan(string githubUrl)
        {
            Console.WriteLine($"Scanning {githubUrl}");

            var qualiTyqualityScanErrors = qualityScanner.QualityScan(githubUrl);
            var securityScanErrors = securityScanner.SecurityScan(githubUrl);
            var dependencyScanErrors = dependencyScanner.DependencyScan(githubUrl);

            Console.WriteLine("Scan report:");
            reportGenerator.GenerateReport(qualiTyqualityScanErrors, securityScanErrors, dependencyScanErrors);
        }
    }
}