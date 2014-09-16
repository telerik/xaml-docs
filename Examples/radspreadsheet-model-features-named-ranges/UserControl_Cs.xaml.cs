using System;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace NamedRanges
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void DefineAndRemoveNamedRanges()
        {
            #region radspreadsheet-model-features-named-ranges_0
            Workbook workbook = new Workbook();
            Worksheet sheet1 = workbook.Worksheets.Add();

            sheet1.Cells[0, 0].SetValue(23738);
            sheet1.Cells[1, 0].SetValue(19012);
            sheet1.Cells[2, 0].SetValue(22544);
            sheet1.Cells[3, 0].SetValue(27690);

            workbook.Names.Add("CorporateTax", "=0.16", new CellIndex(0, 0), "Corporate Tax for Canada");
            sheet1.Names.Add("GrossProfit", "=Sheet1!$A$1:$A$4", new CellIndex(0, 0), "Gross Profit");
            sheet1.Cells[4, 0].SetValue("=SUM(GrossProfit) * CorporateTax");

            workbook.Names.Remove("CorporateTax");
            sheet1.Names.Remove("GrossProfit");
            #endregion

            #region radspreadsheet-model-features-named-ranges_1
            workbook.Names.Remove("CorporateTax");
            sheet1.Names.Remove("GrossProfit");
            #endregion
        }

    }
}
