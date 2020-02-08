using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using DataReport;
using StudentsAndGrades;

namespace ExcelOutput
{
    public class ExcelIO
    {
        public void Output(List<ReportSession> report, string output) 
        {
            Excel.Application ex = new Excel.Application();
            Excel.Workbook workBook = ex.Workbooks.Add();
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            sheet.Name = "Session " + report[0].GroupId.Name;
            sheet.Cells[1, 1] = "Фио";
            sheet.Cells[1, 2] = "Предмет";
            sheet.Cells[1, 3] = "Тип";
            sheet.Cells[1, 4] = "Дата";
            sheet.Cells[1, 5] = "Оценка";
            for (int i=0; i<report.Count;i++ )
            {
                sheet.Cells[i+2, 1] = report[i].StudentId.FullName;
                sheet.Cells[i+2, 2] = report[i].SubjectId.Name;
                sheet.Cells[i+2, 3] = Enum.GetName(typeof(ExamType), report[i].ExamType);
                sheet.Cells[i+2, 4] = report[i].Date.ToString();
                sheet.Cells[i+2, 5] = report[i].Grade.Grade.ToString();
            }
            workBook.SaveAs(output);
            workBook.Close();
        }
        public void Output(List<ReportGroup> report, string output)
        {
            Excel.Application ex = new Excel.Application();
            Excel.Workbook workBook = ex.Workbooks.Add();
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            sheet.Name = "Excel2";
            for (int i = 0; i < report.Count; i++)
            {
                sheet.Cells[i + 1, 1] = report[i].GroupId.Name;
                sheet.Cells[i + 1, 2] = report[i].MinGrade;
                sheet.Cells[i + 1, 3] = report[i].MaxGrade;
                sheet.Cells[i + 1, 4] = report[i].AverageGrade;
            }
            workBook.SaveAs(output);
            workBook.Close();
        }
        public void Output(List<ReportExpelledStudent> report, string output)
        {
            Excel.Application ex = new Excel.Application();
            Excel.Workbook workBook = ex.Workbooks.Add();
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            sheet.Name = "Excel2";
            for (int i = 0; i < report.Count; i++)
            {
                sheet.Cells[i + 1, 1] = report[i].GroupId.Name;
                sheet.Cells[i + 1, 2] = report[i].StudentId.FullName;
                sheet.Cells[i + 1, 3] = report[i].AverageGrade;
            }
            workBook.SaveAs(output);
            workBook.Close();
        }
        public void Output(List<AvgGradeBySpeciality> report, string output)
        {
            Excel.Application ex = new Excel.Application();
            Excel.Workbook workBook = ex.Workbooks.Add();
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            sheet.Name = "Average Grade by Specialities";
            for (int i = 0; i < report.Count; i++)
            {
                sheet.Cells[i + 1, 1] = report[i].SpecialityName;
                sheet.Cells[i + 1, 2] = report[i].AverageGrade;
            }
            workBook.SaveAs(output);
            workBook.Close();
        }
    }
}
