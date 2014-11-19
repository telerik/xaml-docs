using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Csv;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace WorksheetRenameWorksheet
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class Default_Cs : UserControl
    {
        public void RenameSingleWorksheet()
        {
            #region radspreadprocessing-working-with-worksheets-rename-worksheet_0
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Name = "Sam's Worksheet";
            #endregion
        }

        public void RenameWorksheet()
        {
            #region radspreadprocessing-working-with-worksheets-rename-worksheet_1
            Workbook workbook = new Workbook();
            workbook.Worksheets.Add();
            workbook.Worksheets.Add();

            string newWorksheetName = "July's Worksheet";
            int indexOfWorksheetToRename = 0;

            int index = this.radSpreadsheet.Workbook.Worksheets.IndexOf(newWorksheetName);

            if (index == -1 || index == indexOfWorksheetToRename)
            {
                this.radSpreadsheet.Workbook.Worksheets[indexOfWorksheetToRename].Name = newWorksheetName;
            }
            else
            {
                // There already exists worksheet with this name
            }
            #endregion
        }
    }
}