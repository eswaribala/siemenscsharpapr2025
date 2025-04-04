using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV3
{
    class ReadFromExcel
    {
        static void Main(string[] args)
        {
            var fileName = "ProductsApr2025.xlsx";
            IWorkbook workbook = null;
            try
            {
                using(var fs=new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    if (fileName.IndexOf(".xlsx") > 0)
                        workbook = new XSSFWorkbook(fs);
                    else if (fileName.IndexOf(".xls") > 0)
                        workbook = new HSSFWorkbook(fs);



                    ISheet sheet = workbook.GetSheetAt(0);
                    int rowCount = sheet.LastRowNum;
                    for (int i = 0; i <= rowCount; i++)
                    {
                        IRow row = sheet.GetRow(i);
                        if (row != null)
                        {
                            for (int j = 0; j < row.LastCellNum; j++)
                            {
                                Console.Write(row.GetCell(j).ToString() + "\t");
                            }
                            Console.WriteLine();
                        }
                    }
                }


            }
            catch (Exception ex)
            {
            }
        }
    }
}
