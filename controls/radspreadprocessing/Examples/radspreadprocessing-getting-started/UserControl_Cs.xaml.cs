using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Telerik.Windows.Documents.Spreadsheet.DataSeries;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Model.Filtering;
using Telerik.Windows.Documents.Spreadsheet.Model.Sorting;

namespace GettingStarted
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void GettingStarted()
        {
            #region radspreadprocessing-getting-started_0
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            #endregion

            #region radspreadprocessing-getting-started_1
            CellSelection selection = worksheet.Cells[1, 1]; //B2 cell
            selection.SetValue("Hello RadSpreadProcessing");
            #endregion

            #region radspreadprocessing-getting-started_2
            string fileName = "Hello.xlsx";
            IWorkbookFormatProvider formatProvider = new XlsxFormatProvider();

            using (FileStream input = new FileStream(fileName, FileMode.Open))
            {
                workbook = formatProvider.Import(input);
            }
            #endregion
        }
    }
}
