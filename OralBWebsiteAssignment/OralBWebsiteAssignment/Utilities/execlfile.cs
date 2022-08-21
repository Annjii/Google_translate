using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.XSSF.UserModel;

namespace OralBWebsiteAssignment.Utilities
{
    public class execlfile
    {
        public static void ExcelFile()
        {

            String path = @"C:\Users\mindc1may266\source\repos\OralBWebsiteAssignment\OralBWebsiteAssignment\Book1.xlsx";
            XSSFWorkbook workbook = new XSSFWorkbook(File.Open(path, FileMode.Open));
            var Sheet = workbook.GetSheetAt(0).GetRow(0).GetCell(0).StringCellValue.Trim();
            Console.WriteLine("The data in present is ExcelSheet-" + Sheet);

        }
 

    }
}
