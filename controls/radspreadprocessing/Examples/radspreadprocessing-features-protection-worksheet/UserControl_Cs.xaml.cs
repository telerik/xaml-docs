using System;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Model.Protection;

namespace FeaturesProtectionWorksheet
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static void WorksheetProtection()
        {
            #region radspreadprocessing-features-protection-worksheet_0
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            worksheet.Cells[0, 0].SetIsLocked(false);

            worksheet.Protect("telerik", WorksheetProtectionOptions.Default);

            #endregion
        }

        public static void WorksheetUnprotect()
        {
            #region radspreadprocessing-features-protection-worksheet_1
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Protect("telerik", WorksheetProtectionOptions.Default);

            worksheet.Unprotect("telerik");

            #endregion
        }

        public static void WorksheetProtectionMethod()
        {
            #region radspreadprocessing-features-protection-worksheet_2
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            WorksheetProtectionOptions options = new WorksheetProtectionOptions(allowInsertRows: true, allowDeleteRows: true);
            worksheet.Protect("telerik", options);

            #endregion
        }
    }
}
