using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using DataReport;

namespace ExcelOutput
{
    public class ExcelIO
    {
        public void Output(IReport report) {
            Excel.Application ex = new Excel.Application();
            Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            sheet.Name = report.Title;

        }
    }
}
