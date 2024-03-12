using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSendEmail.Helpers
{
    public static class ReadFile
    {

        /// <summary>
        /// Đọc file txt theo hàng trả về 1 danh sách
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Trả về DS Email</returns>
        public static IEnumerable<string> ReadFileByLine(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                // Đọc từng dòng cho đến khi hết file
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if(ITNHelpers.ITNString.CheckGmail(line))
                        yield return line;
                }
            }
        }

        public static IEnumerable<string> ReadFileExcelByFirstColumn(string path)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = package.Workbook.Worksheets[0];

                for (int i = excelWorksheet.Dimension.Start.Row; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    object cellValue = excelWorksheet.Cells[i, 1].Value;

                    if (cellValue != null)
                    {
                        string email = cellValue.ToString();
                        if (ITNHelpers.ITNString.CheckGmail(email))
                            yield return email;
                    }
                }
            }
        }
    }
}
