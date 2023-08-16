using System;
using System.Collections.Generic;
using System.Text;

namespace PocOnTemplateDP.Model
{
    class PDFReport : ReportTemplate
    {
        protected override void GenerateHeader()
        {
            Console.WriteLine("PDF Report Header");
        }

        protected override void GenerateData()
        {
            Console.WriteLine("PDF Report Data");
        }

        protected override void GenerateFooter()
        {
            Console.WriteLine("PDF Report Footer");
        }
    }
}
