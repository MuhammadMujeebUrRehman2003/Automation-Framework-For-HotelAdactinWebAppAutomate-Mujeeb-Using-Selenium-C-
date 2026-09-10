using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.IO;

namespace AdactinWebAutomate.Core
{
    public class ExtentReport
    {
        public static ExtentReports extentReports;
        public static ExtentTest exParentTest;
        public static ExtentTest exChildTest;
        public static string ReportDirectory;   // ← ADD THIS LINE

        public static void CreateReport(string dirpath)
        {
            // Ensure the folder exists
            string directory = Path.GetDirectoryName(dirpath);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            extentReports = new ExtentReports();
            ReportDirectory = directory;
            var sparkReport = new ExtentSparkReporter(dirpath);
            extentReports.AttachReporter(sparkReport);
        }
    }
}