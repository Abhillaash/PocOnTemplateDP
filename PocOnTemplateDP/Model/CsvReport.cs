using System;
using System.Collections.Generic;
using System.Text;

namespace PocOnTemplateDP.Model
{
    class CsvReport : ReportTemplate
    {
        protected override void GenerateHeader()
        {
            Console.WriteLine("CSV Report Header");
        }

        protected override void GenerateData()
        {
            Console.WriteLine("CSV Report Data");
        }

        protected override void GenerateFooter()
        {
            Console.WriteLine("CSV Report Footer");
        }
    }
}
