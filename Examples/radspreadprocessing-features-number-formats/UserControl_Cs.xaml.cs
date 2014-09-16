using System;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region radspreadprocessing-features-number-formats_0
        public void ApplyFormat()
        {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            CellSelection cellSelectionA1 = worksheet.Cells[new CellIndex(0, 0)];
            CellValueFormat scientificFormat = new CellValueFormat("0.00E+00");
            cellSelectionA1.SetFormat(scientificFormat);

            CellSelection cellSelectionA2B3 = worksheet.Cells[new CellRange(new CellIndex(1, 0), new CellIndex(2, 1))];
            CellValueFormat percentageFormat = new CellValueFormat("0.00%");
            cellSelectionA2B3.SetFormat(percentageFormat);
        }
        #endregion


        #region radspreadprocessing-features-number-formats_1
        public void GetFormat()
        {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            CellSelection cellSelectionA1 = worksheet.Cells[new CellIndex(0, 0)];
            CellSelection cellSelectionA2B3 = worksheet.Cells[new CellRange(new CellIndex(1, 0), new CellIndex(2, 1))];

            CellValueFormat cellSelectioA1Format = cellSelectionA1.GetFormat().Value;
            CellValueFormat cellSelectioA2Format = cellSelectionA2B3.GetFormat().Value;
        }
        #endregion
    }
}
