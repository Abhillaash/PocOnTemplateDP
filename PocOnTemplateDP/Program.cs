using System;
using PocOnTemplateDP.Model;

namespace PocOnTemplateDP
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportTemplate pdfReport = new PDFReport();
            pdfReport.GenerateReport();

            Console.WriteLine();

            ReportTemplate csvReport = new CsvReport();
            csvReport.GenerateReport();
        }
    }
}
