using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace FeaturesFormulasCellReference
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void CellReferenceSetValues()
        {
            #region radspreadprocessing-features-formulas-cell-references_0
            Workbook workbook = new Workbook();
            workbook.Worksheets.Add();
            workbook.ActiveWorksheet.Cells[0, 2].SetValue("=A1+B1");
            #endregion

            #region radspreadprocessing-features-formulas-cell-references_1
            workbook.Worksheets.Add();
            Worksheet sheet1 = workbook.Worksheets[0];
            Worksheet samsWorksheet = workbook.Worksheets[1];
            samsWorksheet.Name = "Sam'sWorksheet";

            sheet1.Cells[0, 0].SetValue("='Sam''sWorksheet'!B2");
            #endregion

            #region radspreadprocessing-features-formulas-cell-references_2
            sheet1.Cells[2, 2].SetValue("=SUM(A1:B2)");
            samsWorksheet.Cells[0, 0].SetValue("=PRODUCT(D3:F5)");
            #endregion

        }
    }
}
