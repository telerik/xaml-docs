using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Csv;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ModelWorksheetActivateWorksheet
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region radspreadsheet-model-working-with-worksheets-activate-worksheet_0
        public void ActivateWorksheetDemo()
        {
            Workbook workbook = new Workbook();

            workbook.ActiveSheetChanged += this.Workbook_ActiveSheetChanged;

            workbook.Worksheets.Add();
            workbook.Worksheets.Add();

            workbook.ActiveWorksheet = workbook.Worksheets[1];
        }

        private void Workbook_ActiveSheetChanged(object sender, EventArgs e)
        {
            // the active worksheet is changed
        }
        #endregion
    }
}