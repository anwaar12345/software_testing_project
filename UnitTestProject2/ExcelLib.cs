using Excel = Microsoft.Office.Interop.Excel;

namespace Selenium_AutoTest_Final_Project
{
    class ExcelLib
    {
        public string ExcelSetup(int x, int y)
        {
            string WorkbookPath = @"E:\UnitTestProject2\UnitTestProject2\Book1.xlsx";
            Excel.Application Xapp = new Excel.Application();
            Excel.Workbook Xworkbook = Xapp.Workbooks.Open(WorkbookPath);
            Excel.Worksheet Xworksheet = Xworkbook.Sheets[1];
            Excel.Range Xrange = Xworksheet.UsedRange;
            return Xrange.Cells[x][y].value2;
        }
    }
}
