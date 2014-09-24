using System;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace FeaturesProtectionWorkbook
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static void WorkbookProterction()
        {
            #region radspreadsheet-model-features-protection-workbook_0
            Workbook workbook = new Workbook();
            workbook.Worksheets.Add();

            workbook.Protect("telerik");

            #endregion
        }

        public static void WorkbookUnprotect()
        {
            #region radspreadsheet-model-features-protection-workbook_1
            Workbook workbook = new Workbook();
            workbook.Worksheets.Add();

            workbook.Protect("telerik");

            workbook.Unprotect("telerik");

            #endregion
        }
    }
}
