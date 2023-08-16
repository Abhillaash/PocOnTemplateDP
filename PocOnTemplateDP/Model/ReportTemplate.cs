using System;
using System.Collections.Generic;
using System.Text;

namespace PocOnTemplateDP.Model
{
    abstract class ReportTemplate
    {
        public void GenerateReport()
        {
            GenerateHeader();
            GenerateData();
            GenerateFooter();
        }

        protected abstract void GenerateHeader();
        protected abstract void GenerateData();
        protected abstract void GenerateFooter();
    }
}
