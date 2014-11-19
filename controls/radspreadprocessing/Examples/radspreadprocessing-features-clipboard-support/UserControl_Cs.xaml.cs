using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace FeaturesClipboardSupport
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static void CopyDemo()
        {
            #region radspreadprocessing-features-clipboard-support_0
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            worksheet.Cells[0, 0].SetValue("Product");
            worksheet.Cells[1, 0].SetValue("Service");
            worksheet.Cells[0, 1].SetValue(17.4);
            worksheet.Cells[1, 1].SetValue(12.9);
            worksheet.Cells[2, 0].SetValue("Total");
            worksheet.Cells[2, 1].SetValue("=SUM(A1:B1)");

            CellRange copiedCellRange = new CellRange(0, 0, 2, 1);
            WorksheetFragment worksheetFragment = worksheet.Cells[copiedCellRange].Copy();
            #endregion

        }

        public static void PasteDemo()
        {
            #region radspreadprocessing-features-clipboard-support_1
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            worksheet.Cells[0, 0].SetValue("=CONCATENATE(\"Rad\", \"Spreadsheet\")");
            worksheet.Cells[0, 0].SetForeColor(new ThemableColor(Colors.Green));

            WorksheetFragment worksheetFragment = worksheet.Cells[0, 0].Copy();

            PasteOptions pasteOptions = new PasteOptions(PasteType.All);
            worksheet.Cells[1, 0].Paste(worksheetFragment, pasteOptions);
            #endregion

            #region radspreadprocessing-features-clipboard-support_2
            PasteOptions pasteOptionsValues = new PasteOptions(PasteType.Values);
            worksheet.Cells[2, 0].Paste(worksheetFragment, pasteOptionsValues);
            #endregion

            #region radspreadprocessing-features-clipboard-support_3
            PasteOptions valuesAndFormatting = new PasteOptions(PasteType.Formulas | PasteType.Formats);
            worksheet.Cells[3, 0].Paste(worksheetFragment, valuesAndFormatting);
            #endregion
        }

    }
}
